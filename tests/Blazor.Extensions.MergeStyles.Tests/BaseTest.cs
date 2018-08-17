using Microsoft.JSInterop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.MergeStyles.Tests
{
    public class BaseTest
    {
        public static void Initialize()
        {
            //Initialize a fake IJSRuntime with the necesary functions to work
            var jsRuntimeMock = new Mock<IJSRuntime>();
            jsRuntimeMock.Setup((rt) => rt.InvokeAsync<object>("Init", null)).Returns(Task.FromResult<object>(null));
            jsRuntimeMock.Setup((rt) => rt.InvokeAsync<VendorSettings>(VendorSettings.GET_VENDOR_SETTINGS)).Returns(Task.FromResult(new VendorSettings() { IsMoz = true, IsMs = true, IsOpera = true, IsWebKit = true }));
            JSRuntime.SetCurrentJSRuntime(jsRuntimeMock.Object);
        }

        public void Init() => Initialize();
    }
}
