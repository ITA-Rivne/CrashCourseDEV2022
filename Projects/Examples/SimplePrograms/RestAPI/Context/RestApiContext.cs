using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Context
{
    class RestApiContext
    {
        public Logger log = LogManager.GetCurrentClassLogger(); // for NLog

        public string ApiUrl = "http://127.0.0.1/opencart/index.php?route=api/";
        public string JsonToken;
        public string response;
    }
}
