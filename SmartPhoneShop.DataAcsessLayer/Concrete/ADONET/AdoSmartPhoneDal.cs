using SmartPhoneShop.DataAcsessLayer.Abstract;
using SmartPhoneShop.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneShop.DataAcsessLayer.Concrete.ADONET
{
    public class AdoSmartPhoneDal : ISmartPhoneDal
    {
        public void Add(SmartPhone smartphone)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO SmartPhones (Model,ScreenSize,Price) VALUES (@Model,@ScreenSize,@Price)"))
            {
                cmd.Parameters.AddWithValue("Model", smartphone.Model);
                cmd.Parameters.AddWithValue("ScreenSize", smartphone.ScreenSize);
                cmd.Parameters.AddWithValue("Price", smartphone.Price);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public void Delete(SmartPhone smartphone)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM SmartPhones where SmartPhoneId =@SmartPhoneId"))
            {
                cmd.Parameters.AddWithValue("SmartPhoneId", smartphone.SmartPhoneId);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public void Update(SmartPhone smartphone)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE SmartPhones set Model=@Model,ScreenSize=@ScreenSize,Price=@Price where SmartPhoneId=@SmartPhoneId"))
            {
                cmd.Parameters.AddWithValue("SmartPhoneId", smartphone.SmartPhoneId);
                cmd.Parameters.AddWithValue("Model", smartphone.Model);
                cmd.Parameters.AddWithValue("ScreenSize", smartphone.ScreenSize);
                cmd.Parameters.AddWithValue("Price", smartphone.Price);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public SmartPhone Get(Expression<Func<SmartPhone, bool>> filter)
        {
            var query = (from smartphone in GetAll() where smartphone.SmartPhoneId == Convert.ToInt32(filter) select smartphone);
            return (SmartPhone)query;
        }

        public List<SmartPhone> GetAll(Expression<Func<SmartPhone, bool>> filter = null)
        {
            var smartphonelist = new List<SmartPhone>();
            SqlCommand cmd = new SqlCommand("SELECT * from SmartPhones");

            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                SmartPhone smartphone = new SmartPhone
                {
                    SmartPhoneId = Convert.ToInt32(reader[0]),
                    Model = reader[1].ToString(),
                    ScreenSize = Convert.ToDouble(reader[2]),
                    Price = Convert.ToDecimal(reader[3]),
                };
                smartphonelist.Add(smartphone);
            }
            return smartphonelist;
        }

       
    }
}
