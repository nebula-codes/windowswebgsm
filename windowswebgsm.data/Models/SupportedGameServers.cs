using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace windowswebgsm.data.Models
{
    public class SupportedGameServers
    {
        private SupportedGameServers(string value) { Value = value; }
        public string Value { get; private set; }

        public enum Games
        {
            [Description("No Game Selected")]
            None = 0,
            [Description("7 Days To Die")]
            SevenDaysToDie = 294420,
            [Description("Ark: Survival Evolved")]
            ArkSurvivalEvolved = 346110,
            [Description("Factorio")]
            Factorio = 427520
        }


        public override string ToString()
        {
            return Value;
        }
    }

    public static class Extensions
    {
        public static string ToDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
