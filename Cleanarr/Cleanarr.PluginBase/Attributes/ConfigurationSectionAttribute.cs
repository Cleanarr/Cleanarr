using System;

namespace Cleanarr.PluginBase.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ConfigurationSectionAttribute : Attribute
    {
        public string Name { get; }

        public ConfigurationSectionAttribute(string name)
        {
            Name = name;
        }
    }
}
