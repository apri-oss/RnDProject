using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;
using RnDProject.Models;
using RnDProject.Views;

namespace RnDProject.Presenters
{
    public class PostLoginPresenters
    {
        PostLoginView loginview;

        public PostLoginPresenters(PostLoginView view)
        {
            loginview = view;
        }

        public void UserData()
        {
            Models.PostLogin login = new Models.PostLogin();
            login.Username = loginview.UsernameText;
            login.Password = loginview.PasswordText;



            var postData = new
            {
                data = new { login = loginview.UsernameText, password = loginview.PasswordText }
            };

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api-demo.procura.id/api/");

            var json = System.Text.Json.JsonSerializer.Serialize(postData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync("login", content).Result;

            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                var postResponse = System.Text.Json.JsonSerializer.Deserialize<PostLogin>(responseContent, options);
                System.Diagnostics.Debug.WriteLine("Login Success: " + responseContent);
                loginview.UserDataText = responseContent;



            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Error: " + response.StatusCode);
                loginview.UserDataText = "Error: " + response.StatusCode;
            }
        }

    }
}
