using System.Reflection;

namespace windowswebgsm.Data.Models
{
    ///<Summary>
    /// Windows Web GSM Instance Information
    ///</Summary>

    public class WWGSM
    {
        /// <summary>
        /// WWGSM Instance Version
        /// </summary>
        public string Version { get; set; } = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        /// <summary>
        /// Maximum Server Count
        /// </summary>
        public int MAX_SERVER { get; } = 50;
    }
}
