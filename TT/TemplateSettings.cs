using System;
using System.Collections.Generic;

namespace TT
{
    public class TemplateSettings
    {
        public IDictionary<string, object> Variables { get; private set; }

        public TemplateSettings()
        {
            Variables = new Dictionary<string, object>();            
        }

        public TemplateSettings(IDictionary<string, object> variables)
        {
            Variables = variables;
        }
    }
}