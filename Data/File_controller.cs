using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo_List.Data
{
    public static class File_controller
    {
        public static async Task SaveAsFileAsync(this IJSRuntime js, string filename, byte[] data, string type="application/octet-stream")
        {
            await js.InvokeAsync<object>("File_controller.saveAsFile", filename, type, Convert.ToBase64String(data));
        }
    }
}
