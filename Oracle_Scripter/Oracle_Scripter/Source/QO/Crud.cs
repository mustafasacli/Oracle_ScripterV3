namespace Oracle_Scripter.Source.QO
{
    internal class Crud
    {
        internal static string GetBaseObjectListFormat()
        {
            return
                @"SELECT * FROM (SELECT NAME As Name, TYPE As TypeName, MAX(LINE) AS LineNumber
                    FROM ALL_SOURCE
                    WHERE OWNER = '#SCHEMA#'
                    AND (TYPE IN('#OBJECTTYPES#'))
                    GROUP BY TYPE, Name)
                    ORDER BY TypeName, Name";
        }

        internal static string GetBaseObjectListFormatBySchema()
        {
            return
                @"SELECT * FROM (SELECT NAME As Name, TYPE As TypeName, MAX(LINE) AS LineNumber
                    FROM ALL_SOURCE
                    WHERE OWNER = '#SCHEMA#'
                    AND (TYPE IN('#OBJECTTYPES#'))
                    AND NAME NOT LIKE '%$%'
                    AND NAME NOT LIKE '%=%'
                    GROUP BY TYPE, Name)
                    ORDER BY TypeName, Name";
        }

        /*
          return
                @"SELECT * FROM (SELECT NAME As Name, TYPE As TypeName, MAX(LINE) AS LineNumber
                    FROM ALL_SOURCE
                    WHERE OWNER = '#SCHEMA#'
                    AND (TYPE IN('#OBJECTTYPES#'))
                    GROUP BY TYPE, Name)
                    ORDER BY TypeName, Name";
         */

        internal static string GetObjectScript()
        {
            return @"SELECT *
                     FROM ALL_SOURCE
                     WHERE OWNER = '#SCHEMA#'
                     AND NAME='#OBJECTNAME#'
                     ORDER BY LINE";
        }

        internal static string GetObjectListScript()
        {
            return @"SELECT *
                     FROM ALL_SOURCE
                     WHERE OWNER = '#SCHEMA#'
                     ORDER BY NAME, LINE";
        }

        internal static string GetObjectListScriptBySchema()
        {
            return @"SELECT *
                     FROM ALL_SOURCE
                     WHERE OWNER = '#SCHEMA#'
                     ORDER BY NAME, LINE";
        }

    }
}
