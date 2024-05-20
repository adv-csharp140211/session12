using app07.Model;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace App12;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void buttonText_Click(object sender, EventArgs e)
    {
        using var ctx = new AppDbContext();
        var count = await ctx.Products.CountAsync();
        MessageBox.Show($"Total {count}");
    }

    private void buttonTransactionFail_Click(object sender, EventArgs e)
    {
        AddProduct();
        AddCategory();

        //Transaction -> همه دستوارت با موفقیت اجرابشن یا اگه به مشگل خورد، به وضعیت قبلی برگردد
    }

    private void AddCategory()
    {
        using var ctx = new AppDbContext();
        var category = new Category { Description = "Test 2", Name = "CAT ----- 5/20/2024 17:48:22.411 RelationalEventId.ConnectionClosed[20003] (Microsoft.EntityFrameworkCore.Database.Connection) 5/20/2024 17:48:22.411 RelationalEventId.ConnectionClosed[20003] (Microsoft.EntityFrameworkCore.Database.Connection)" };
        ctx.Add(category);
        ctx.SaveChanges();
    }

    private void AddProduct()
    {
        using var ctx = new AppDbContext();
        var product = new Product { Name = "Test Transaction 2", Description = "test", CategoryId = 4 };
        ctx.Add(product);
        ctx.SaveChanges();
    }

    private void buttonTransactionEF_Click(object sender, EventArgs e)
    {
        using var ctx = new AppDbContext();

        var product = new Product { Name = "Test Transaction 2", Description = "test", CategoryId = 4 };
        ctx.Add(product);

        var category = new Category { Description = "Test 2", Name = "CAT ----- 5/20/2024 17:48:22.411 RelationalEventId.ConnectionClosed[20003] (Microsoft.EntityFrameworkCore.Database.Connection) 5/20/2024 17:48:22.411 RelationalEventId.ConnectionClosed[20003] (Microsoft.EntityFrameworkCore.Database.Connection)" };
        ctx.Add(category);

        ctx.SaveChanges(); //Transaction 

    }

    private void buttonTransactionScope_Click(object sender, EventArgs e)
    {
        using var scope = new TransactionScope();
        AddProduct();
        AddCategory();
        scope.Complete(); //transaction ok: commit, fail: rollback        

        //repository pattern
        //unit of work
    }

    private void button1_Click(object sender, EventArgs e)
    {
        //Dependency Injection
        //Repository scope

        var repo = new Repository();
        repo.Create(new Product { Name = "Test Transaction 4", Description = "test", CategoryId = 4 });
        repo.Create(new Category { Description = "Test 2", Name = "CAT ----- 5/20/2024 17:48:22.411 RelationalEventId.ConnectionClosed[20003] (Microsoft.EntityFrameworkCore.Database.Connection) 5/20/2024 17:48:22.411 RelationalEventId.ConnectionClosed[20003] (Microsoft.EntityFrameworkCore.Database.Connection)" });
        repo.SaveChanges();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (textBox1.Text == "P@ss!")
        {
            MessageBox.Show("yes 🎉");
        }
        else
        {
            MessageBox.Show("no!");
        }
    }

    private void buttonSQLite_Click(object sender, EventArgs e)
    {
        using (var connection = new SqliteConnection("Data Source=hello.db"))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText =
            @"
        SELECT name
        FROM user
        WHERE id = $id
    ";
            command.Parameters.AddWithValue("$id", 1);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var name = reader.GetString(0);

                    Console.WriteLine($"Hello, {name}!");
                }
            }
        }
    }
}
