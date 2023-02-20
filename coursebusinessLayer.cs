using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disconnected_mode
{
    internal class coursebusinessLayer
    {
        //get all
        public static DataTable GetAll()
        {
            return DatabaseLayer.select("select * from course");
        }
        // get by id

        public static DataTable GetById(int id)
        {
            return DatabaseLayer.select($"select * from course where Crs_Id ={id}");
        }

        //add

        public static int add (int id , string name , int dur , int top_id)
        {
            return DatabaseLayer.DMLcommand($"insert into Course(Crs_Id ,Crs_Name , Crs_Duration , Top_Id )values({id},'{name}' , {dur}, {top_id})");
        }

        //edit

        public static int Edit(int id , string name , int dur , int top_id)
        {
            return DatabaseLayer.DMLcommand($"update Course set Crs_Name = '{name}', Crs_Duration = {dur} , Top_Id={top_id} where Crs_Id = {id}");
        }


        //delete
        public static int Delete(int id)
        {
            return DatabaseLayer.DMLcommand($"delete from Course where Crs_Id ={id}");
        }

    }
}
