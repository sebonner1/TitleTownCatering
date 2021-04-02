using System.IO;

namespace TitleTownCatering.Models
{
    public class AddMenuItem: IAddMenuItems
    {
        public void AddMenuItem()
        {
            string currentDir = Directory.GetCurrentDirectory();
            string cs = "URI=file:"+currentDir+@"/menu.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(con);

            Console.WriteLine("What would you like your menu item description to say?");
            string newMenuItemDescription = Console.ReadLine();
            Console.WriteLine("What is the price of your menu item?");
            string newMenuItemPrice = Console.ReadLine();

            cmd.CommandText = @"INSERT INTO myItems(description, price) VALUES(@description, @price)";
            cmd.Parameters.AddWithValue("@description", newMenuItemDescription);
            cmd.Parameters.AddWithValue("@price", newMenuItemPrice);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

        }
    }
}