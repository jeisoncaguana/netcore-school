namespace netcore_school.Constants
{
    public class HttpConstant
    {
        public static string STATUS_HTTP_SUCCESS = "success";
        public static string STATUS_HTTP_ERROR = "error";
        public static string STATUS_HTTP_WARNING = "warning";
        public static string STATUS_HTTP_INFO = "info";

        public static string Mode { get; private set; } = "developer"; // Valor por defecto

        public static void Configure(string mode)
        {
            Mode = mode ?? "developer"; // Si no viene nada, queda developer
        }
    }
}
