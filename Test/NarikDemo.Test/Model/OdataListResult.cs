using System.Collections.Generic;
using Newtonsoft.Json;

namespace NarikDemo.Test.Model
{
    public class OdataListResult<T>
    {
        [JsonProperty("value")]
        public List<T> Value { get; set; }
    }
}
