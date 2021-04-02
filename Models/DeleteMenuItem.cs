namespace TitleTownCatering.Models
{
    public class DeleteMenuItem
    {
        public void DeleteMenuItem(int itemID)
        {
            string cs = @"URI=/Users/williambonner/Source/repos/pa4-sebonner1-1/posts.db";
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