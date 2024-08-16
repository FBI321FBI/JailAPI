using CounterStrikeSharp.API;
using JailAPI.Interface.Model;
using System.Collections.Concurrent;
using System.Data;

namespace JailAPI.Model
{
    public class SerializationGuardsFileModel : ISerializationGuardsFileModel
    {
        public string Name { get; }
        public string Description { get; }

		#region .ctor
		public SerializationGuardsFileModel(string name, string description)
        {
            Name = name;
            Description = description;
        }
        #endregion
    }
}
