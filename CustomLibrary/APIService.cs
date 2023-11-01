using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CustomLibrary
{
    public class APIService<T>
    {
        public List<T> index(String apiUrl)
        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(apiUrl).Result;

                if (response.IsSuccessStatusCode)
                {
                    // Đọc dữ liệu từ phản hồi
                    List<T> responseData = response.Content.ReadAsAsync<List<T>>().Result;
                    return responseData;
                }
                else
                {
                    // Xử lý khi yêu cầu không thành công
                    Console.WriteLine("Yêu cầu không thành công. Mã trạng thái: " + response.StatusCode);
                    return null;
                }
            }
        }

        public T show(String apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(apiUrl).Result;

                if (response.IsSuccessStatusCode)
                {
                    // Đọc dữ liệu từ phản hồi
                    string responseData = response.Content.ReadAsStringAsync().Result;

                    // Chuyển đổi dữ liệu thành kiểu T
                    T result = JsonConvert.DeserializeObject<T>(responseData);

                    return result;
                }
                else
                {
                    // Xử lý khi yêu cầu không thành công
                    Console.WriteLine("Yêu cầu không thành công. Mã trạng thái: " + response.StatusCode);
                    return default(T);
                }
            }
        }

        public bool store(String apiUrl, T data)
        {

            using (HttpClient client = new HttpClient())
            {
                // Chuyển đổi đối tượng data thành JSON
                string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = client.PostAsync(apiUrl, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    // Trả về true nếu yêu cầu thành công
                    return true;
                }
                else
                {
                    // Trả về false nếu yêu cầu không thành công
                    Console.WriteLine("Yêu cầu không thành công. Mã trạng thái: " + response.StatusCode);
                    return false;
                }
            }
        }

        public bool update(String apiUrl, T updatedData)
        {
            using (HttpClient client = new HttpClient())
            {
                // Chuyển đổi đối tượng updatedData thành JSON
                string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(updatedData);
                HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = client.PutAsync(apiUrl, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    // Trả về true nếu yêu cầu thành công
                    return true;
                }
                else
                {
                    // Xử lý khi yêu cầu không thành công
                    Console.WriteLine("Yêu cầu không thành công. Mã trạng thái: " + response.StatusCode);
                    return false;
                }
            }
        }

        public bool delete(String apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.DeleteAsync(apiUrl).Result;

                if (response.IsSuccessStatusCode)
                {
                    // Trả về true nếu yêu cầu thành công
                    return true;
                }
                else
                {
                    // Xử lý khi yêu cầu không thành công
                    Console.WriteLine("Yêu cầu không thành công. Mã trạng thái: " + response.StatusCode);
                    return false;
                }
            }
        }
    }
}
