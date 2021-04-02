using System.Data.SQLite;

namespace TitleTownCatering.Models
{
    public class DeleteMenuItem : IDeleteMenuItems
    {
        public void DeleteMenuItem(int itemID)
        {
            string cs = @"URI=/Users/williambonner/Source/repos/TitleTownCatering/menu.db";
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