
namespace CompilatorScript.Core
{
    using System.Runtime.Remoting.Metadata.W3cXsd2001;
    using System.Security.Policy;

    public static class RegexPatterns
    {
        //DECLARATION PATTERNS
        //VARIABLES
        public static string INTEGER_DECLARE_PATTERN = "^integer[\\s]+[a-zA-Z]+[\\w]*[\\s]*;$";

        public static string STRING_DECLARE_PATTERN = "^string[\\s]+[a-zA-Z]+[\\w]*[\\s]*;$";

        public static string CHARACTER_DECLARE_PATTERN = "^character[\\s]+[a-zA-Z]+[\\w]*[\\s]*;$";

        public static string DOUBLE_DECLARE_PATTERN = "^double[\\s]+[a-zA-Z]+[\\w]*[\\s]*;$";

        public static string BOOLEAN_DECLARE_PATTERN = "^boolean[\\s]+[a-zA-Z]+[\\w]*[\\s]*;$";
                   
        //ARRAYS         
        public static string INTEGER_ARRAY_DECLARE_PATTERN = "^integer\\[\\][\\s]+[a-zA-Z]+[\\w]*[\\s]*;$";

        public static string STRING_ARRAY_DECLARE_PATTERN = "^string\\[\\][\\s]+[a-zA-Z]+[\\w]*[\\s]*;$";

        public static string CHARACTER_ARRAY_DECLARE_PATTERN = "^character\\[\\][\\s]+[a-zA-Z]+[\\w]*[\\s]*;$";

        public static string DOUBLE_ARRAY_DECLARE_PATTERN = "^double\\[\\][\\s]+[a-zA-Z]+[\\w]*[\\s]*;$";

        public static string BOOLEAN_ARRAY_DECLARE_PATTERN = "^boolean\\[\\][\\s]+[a-zA-Z]+[\\w]*[\\s]*;$";

        //INITIALISATION PATTERNS
        //VARIABLES
        public static string INTEGER_INIT_PATTERN = "^[a-zA-Z]+[\\w]*[\\s]*=[\\s]*[\\d]+[\\s]*;$";

        public static string STRING_INIT_PATTERN = "^[a-zA-Z]+[\\w]*[\\s]*=[\\s]*\".*\"+[\\s]*;$";

        public static string CHARACTER_INIT_PATTERN = "^[a-zA-Z]+[\\w]*[\\s]*=[\\s]*\'.{1}\'+[\\s]*;$";

        public static string DOUBLE_INIT_PATTERN = "^[a-zA-Z]+[\\w]*[\\s]*=[\\s]*[\\d]+(\\.?[\\d]+)?[\\s]*;$";

        public static string BOOLEAN_INIT_PATTERN = "^[a-zA-Z]+[\\w]*[\\s]*=[\\s]*(true|false)[\\s]*;$";

        //ARRAYS
        public static string INTEGER_ARRAY_INIT_PATTERN = "^[a-zA-Z]+[\\w]*[\\s]*=[\\s]*new[\\s]+integer\\[[\\d]+\\];$";

        public static string STRING_ARRAY_INIT_PATTERN = "^[a-zA-Z]+[\\w]*[\\s]*=[\\s]*new[\\s]+string\\[[\\d]+\\];$";

        public static string CHARACTER_ARRAY_INIT_PATTERN = "^[[a-zA-Z]+[\\w]*[\\s]*=[\\s]*new[\\s]+character\\[[\\d]+\\];$";

        public static string DOUBLE_ARRAY_INIT_PATTERN = "^[a-zA-Z]+[\\w]*[\\s]*=[\\s]*new[\\s]+double\\[[\\d]+\\];$";

        public static string BOOLEAN_ARRAY_INIT_PATTERN = "^[a-zA-Z]+[\\w]*[\\s]*=[\\s]*new[\\s]+boolean\\[[\\d]+\\];$";

        //DECLARATION AND INITIALISATION (ON ONE LINE) PATTERNS
        //VARIABLES
        public static string INTEGER_DECLARE_AND_INIT_PATTERN = "^integer[\\s]+[a-zA-Z]+[\\w]*[\\s]*=[\\s]*[\\d]+[\\s]*;$";

        public static string STRING_DECLARE_AND_INIT_PATTERN = "^string[\\s]+[a-zA-Z]+[\\w]*[\\s]*=[\\s]*\".*\"[\\s]*;$";

        public static string CHARACTER_DECLARE_AND_INIT_PATTERN = "^character[\\s]+[a-zA-Z]+[\\w]*[\\s]*=[\\s]*\'.{1}\'[\\s]*;$";

        public static string DOUBLE_DECLARE_AND_INIT_PATTERN = "^double[\\s]+[a-zA-Z]+[\\w]*[\\s]*=[\\s]*[\\d]+(\\.?[\\d]+)?[\\s]*;$";

        public static string BOOLEAN_DECLARE_AND_INIT_PATTERN = "^boolean[\\s]+[a-zA-Z]+[\\w]*[\\s]*=[\\s]*(true|false)[\\s]*;$";

        //ARRAYS
        public static string INTEGER_ARRAY_DECLARE_AND_INIT_PATTERN =
            "^integer\\[\\][\\s]+[a-zA-Z]+[\\w]*[\\s]*=[\\s]*new[\\s]+integer\\[[\\d]+\\];$";

        public static string STRING_ARRAY_DECLARE_AND_INIT_PATTERN =
            "^string\\[\\][\\s]+[a-zA-Z]+[\\w]*[\\s]*=[\\s]*new[\\s]+string\\[[\\d]+\\];$";

        public static string CHARACTER_ARRAY_DECLARE_AND_INIT_PATTERN =
            "^character\\[\\][\\s]+[a-zA-Z]+[\\w]*[\\s]*=[\\s]*new[\\s]+character\\[[\\d]+\\];$";

        public static string DOUBLE_ARRAY_DECLARE_AND_INIT_PATTERN =
            "^double\\[\\][\\s]+[a-zA-Z]+[\\w]*[\\s]*=[\\s]*new[\\s]+double\\[[\\d]+\\];$";

        public static string BOOLEAN_ARRAY_DECLARE_AND_INIT_PATTERN =
            "^boolean\\[\\][\\s]+[a-zA-Z]+[\\w]*[\\s]*=[\\s]*new[\\s]+boolean\\[[\\d]+\\];$";

        //BOOLEAN VALIDATION PATTERNS
        //VARIABLE PATTERNS
        public static string BOOLEAN_VALIDATE_VARIABLE_X_NUMBER_PATTERN =
            "^[\\s]*[a-zA-Z]+[\\w]*[\\s]*(>=|<=|==|!=|<|>)[\\s]*[\\d]+(\\.?[\\d]+)?[\\s]*$";

        public static string BOOLEAN_VALIDATE_VARIABLE_X_STRING_PATTERN =
            "^[\\s]*[a-zA-Z]+[\\w]*[\\s]*(>=|<=|==|!=|<|>)[\\s]*\".*\"[\\s]*$";

        public static string BOOLEAN_VALIDATE_VARIABLE_X_CHARACTER_PATTERN =
            "^[\\s]*[a-zA-Z]+[\\w]*[\\s]*(>=|<=|==|!=|<|>)[\\s]*\'.{1}\'[\\s]*$";

        public static string BOOLEAN_VALIDATE_VARIABLE_X_BOOLEAN_PATTERN =
            "^[\\s]*[a-zA-Z]+[\\w]*[\\s]*(>=|<=|==|!=|<|>)[\\s]*(true|false)[\\s]*$";

        public static string BOOLEAN_VALIDATE_VARIABLE_X_VARIABLE_PATTERN =
            "^[\\s]*[a-zA-Z]+[\\w]*[\\s]*(>=|<=|==|!=|<|>)[\\s]*[a-zA-Z]+[\\w]*[\\s]*$";

        //AND REVERSE
        public static string BOOLEAN_VALIDATE_NUMBER_X_VARIABLE_PATTERN =
            "^[\\s]*[\\d]+(\\.?[\\d]+)?[\\s]*(>=|<=|==|!=|<|>)[\\s]*[a-zA-Z]+[\\w]*[\\s]*$";

        public static string BOOLEAN_VALIDATE_STRING_X_VARIABLE_PATTERN =
            "^[\\s]*\".*\"[\\s]*(>=|<=|==|!=|<|>)[\\s]*[a-zA-Z]+[\\w]*[\\s]*$";

        public static string BOOLEAN_VALIDATE_CHARACTER_X_VARIABLE_PATTERN =
            "^[\\s]*\'.{1}\'[\\s]*(>=|<=|==|!=|<|>)[\\s]*[a-zA-Z]+[\\w]*[\\s]*$";

        public static string BOOLEAN_VALIDATE_BOOLEAN_X_VARIABLE_PATTERN =
            "^[\\s]*(true|false)[\\s]*(>=|<=|==|!=|<|>)[\\s]*[a-zA-Z]+[\\w]*[\\s]*$";

        //NUMBERS, STRINGS, CHARACTERS, BOOLEANS
        public static string BOOLEAN_VALIDATE_NUMBER_X_NUMBER_PATTERN =
            "^[\\s]*[\\d]+(\\.?[\\d]+)?[\\s]*(>=|<=|==|!=|<|>)[\\s]*[\\d]+(\\.?[\\d]+)?[\\s]*$";

        public static string BOOLEAN_VALIDATE_STRING_X_STRING_PATTERN =
            "^[\\s]*\".*\"[\\s]*(>=|<=|==|!=|<|>)[\\s]*\".*\"[\\s]*$";

        public static string BOOLEAN_VALIDATE_CHARACTER_X_CHARACTER_PATTERN =
            "^[\\s]*\'.{1}\'[\\s]*(>=|<=|==|!=|<|>)[\\s]*\'.{1}\'[\\s]*$";

        public static string BOOLEAN_VALIDATE_BOOLEAN_X_BOOLEAN_PATTERN =
            "^[\\s]*(true|false)[\\s]*(==|!=)[\\s]*(true|false)[\\s]*$";

        public static string BOOLEAN_VALIDATE_NUMBER_X_CHARACTER_PATTERN =
            "^[\\s]*-?[\\d]+(\\.?[\\d]+)?[\\s]*(>=|<=|==|!=|<|>)[\\s]*\'.{1}\'[\\s]*$";

        public static string BOOLEAN_VALIDATE_CHARACTER_X_NUMBER_PATTERN =
            "^[\\s]*\'.{1}\'[\\s]*(>=|<=|==|!=|<|>)[\\s]*-?[\\d]+(\\.?[\\d]+)?[\\s]*$";

        
    }
}
