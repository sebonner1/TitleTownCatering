using System.Data.SQLite;

namespace TitleTownCatering.Models
{
    public class DeleteMenuItem : IDeleteMenuItems
    {
        public void DeleteMenuItem(int itemID)
        {
            string currentDir = Directory.GetCurrentDirectory();
            string cs = @"URI=file:"+currentDir+"/menu.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = @"DELETE FROM myItems WHERE id = @ID";
            cmd.Parameters.AddWithValue("@ID",itemID);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}