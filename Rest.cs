using System.Net.Http.Json;
using System.Text.Json;

namespace BF_Client
{
    public static class Rest
    {
        private static string _url = string.Empty;
        public static void SetURL(string url)
        {
            _url = url;
        }

        static readonly HttpClient client = new ();

        public static async Task<T> RestPost<T>(string cmd, object req)
        {
            T res = default;
            try
            {
                var content = JsonContent.Create(req);
                using HttpResponseMessage response = await client.PostAsync(_url + cmd, content);

                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                res = JsonSerializer.Deserialize<T>(responseBody);

            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Post" + typeof(T).Name, "Connection error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);

                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            finally
            {
            }
            return res;
        }

        public static async Task RestPut<T>(string cmd, object req)
        {
            try
            {
                var content = JsonContent.Create(req);
                using HttpResponseMessage response = await client.PutAsync(_url + cmd, content);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Put:" + typeof(T).Name, "Connection error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);

                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }

        public static async Task<T> RestGet<T>(string cmd)
        {
            T result = default(T);
            try
            {
                using HttpResponseMessage response = await client.GetAsync(_url + cmd);

                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<T>(responseBody);
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Get:" + typeof(T).Name, "Connection error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);

                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return result;
        }
    }
}
