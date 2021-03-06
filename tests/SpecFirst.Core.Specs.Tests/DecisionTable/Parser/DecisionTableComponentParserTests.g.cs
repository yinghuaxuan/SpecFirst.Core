//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by SpecFirst source generator.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpecFirst.Core.Specs.Tests.DecisionTable.Parser.DecisionTableComponentParser
{
    using System;
    using System.Collections.Generic;
    using Xunit;
    
    public partial class parse_decision_table_name_and_type
    {
        private static readonly string decision_table_default = "<table>   <tbody>     <tr>       <td colspan=\"3\"> Table Name </td>     </tr>     <tr>       <td> #Description </td>       <td> Table Header 1 </td>       <td> Table Header 2? </td>     </tr>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";
        private static readonly string decision_table = "<table>   <tbody>     <tr>       <td colspan=\"3\"> decision:Table Name </td>     </tr>     <tr>       <td> #Description </td>       <td> Table Header 1 </td>       <td> Table Header 2? </td>     </tr>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";
        private static readonly string decision_table_with_theader = "<table>   <thead>     <tr>       <td colspan=\"3\"> Decision:Table Name </td>     </tr>     <tr>       <th> #Description </th>       <th> Table Header 1 </th>       <th> Table Header 2? </th>     </tr>   </thead>   <tbody>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";
        private static readonly string comment_decision_table = "<table>   <tbody>     <tr>       <td colspan=\"3\"> comment:Table Name </td>     </tr>     <tr>       <td> #Description </td>       <td> Table Header 1 </td>       <td> Table Header 2? </td>     </tr>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";
        private static readonly string setup_decision_table = "<table>   <tbody>     <tr>       <td colspan=\"3\"> setup:Table Name </td>     </tr>     <tr>       <td> #Description </td>       <td> Table Header 1 </td>       <td> Table Header 2? </td>     </tr>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";

        [Theory]
        [MemberData(nameof(get_test_data))]
        public void parse_decision_table_name_and_type_tests(string decision_table, string table_type, string table_name)
        {
            (string table_type_output, string table_name_output) = parse_decision_table_name_and_type_implementation(decision_table);
            Assert.Equal(table_type_output, table_type);
            Assert.Equal(table_name_output, table_name);
        }

        public static IEnumerable<object[]> get_test_data()
        {
            var data = new List<object[]>
            {
                new object[] { decision_table_default, "Decision", "Table Name" }, // Decision table without prefix
                new object[] { decision_table, "Decision", "Table Name" }, // Decision table
                new object[] { decision_table_with_theader, "Decision", "Table Name" }, // Decision table with th headers
                new object[] { comment_decision_table, "Comment", "Table Name" }, // Comment decision table
                new object[] { setup_decision_table, "Setup", "Table Name" }, // Setup decision table
            };

            return data;
        }

        private partial (string, string) parse_decision_table_name_and_type_implementation(string decision_table);

    }

    public partial class parse_decision_table_headers
    {
        private static readonly string decision_table_default = "<table>   <tbody>     <tr>       <td colspan=\"3\"> Table Name </td>     </tr>     <tr>       <td> #Description </td>       <td> Table Header 1 </td>       <td> Table Header 2? </td>     </tr>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";
        private static readonly string decision_table = "<table>   <tbody>     <tr>       <td colspan=\"3\"> decision:Table Name </td>     </tr>     <tr>       <td> #Description </td>       <td> Table Header 1 </td>       <td> Table Header 2? </td>     </tr>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";
        private static readonly string decision_table_with_theader = "<table>   <thead>     <tr>       <td colspan=\"3\"> Decision:Table Name </td>     </tr>     <tr>       <th> #Description </th>       <th> Table Header 1 </th>       <th> Table Header 2? </th>     </tr>   </thead>   <tbody>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";
        private static readonly string comment_decision_table = "<table>   <tbody>     <tr>       <td colspan=\"3\"> comment:Table Name </td>     </tr>     <tr>       <td> #Description </td>       <td> Table Header 1 </td>       <td> Table Header 2? </td>     </tr>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";
        private static readonly string setup_decision_table = "<table>   <tbody>     <tr>       <td colspan=\"3\"> setup:Table Name </td>     </tr>     <tr>       <td> #Description </td>       <td> Table Header 1 </td>       <td> Table Header 2? </td>     </tr>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";
        private static readonly string decision_table_with_decorations_in_headers = "<table>   <thead>     <tr>       <td colspan=\"3\"> Decision:Table Name </td>     </tr>     <tr>       <th> #<a href=\"#\" title=\"ignore_case\" data-href=\"#\">Description</a> </th>       <th> <a href=\"#\" title=\"ignore_case|ignore_all_spaces\" data-href=\"#\">Table Header 1</a> </th>       <th> <a href=\"#\" title=\"ignore_case|ignore_line_ending\" data-href=\"#\">Table Header 2</a>? </th>     </tr>   </thead>   <tbody>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";
        private static readonly string decision_table_with_decorations_in_th_headers = "<table>   <thead>     <tr>       <td colspan=\"3\"> Decision:Table Name </td>     </tr>     <tr>       <th> <a href=\"#\" title=\"ignore_case\" data-href=\"#\">#Description</a> </th>       <th> <a href=\"#\" title=\"ignore_case\" data-href=\"#\">Table Header 1</a> </th>       <th> <a href=\"#\" title=\"ignore_case|ignore_line_ending\" data-href=\"#\">Table Header 2?</a> </th>     </tr>   </thead>   <tbody>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";

        [Theory]
        [MemberData(nameof(get_test_data))]
        public void parse_decision_table_headers_tests(string decision_table, string input_header, string output_header, string comment_header)
        {
            (string input_header_output, string output_header_output, string comment_header_output) = parse_decision_table_headers_implementation(decision_table);
            Assert.Equal(input_header_output, input_header);
            Assert.Equal(output_header_output, output_header);
            Assert.Equal(comment_header_output, comment_header);
        }

        public static IEnumerable<object[]> get_test_data()
        {
            var data = new List<object[]>
            {
                new object[] { decision_table_default, "Table Header 1", "Table Header 2", "Description" }, // Decision table without prefix
                new object[] { decision_table, "Table Header 1", "Table Header 2", "Description" }, // Decision table
                new object[] { decision_table_with_theader, "Table Header 1", "Table Header 2", "Description" }, // Decision table with th headers
                new object[] { comment_decision_table, "Table Header 1", "Table Header 2", "Description" }, // Comment decision table
                new object[] { setup_decision_table, "Table Header 1", "Table Header 2", "Description" }, // Setup decision table
                new object[] { decision_table_with_decorations_in_headers, "Table Header 1", "Table Header 2", "Description" }, // Headers with decorations
                new object[] { decision_table_with_decorations_in_th_headers, "Table Header 1", "Table Header 2", "Description" }, // th headers with decorations
            };

            return data;
        }

        private partial (string, string, string) parse_decision_table_headers_implementation(string decision_table);

    }

    public partial class parse_header_decorations
    {
        private static readonly string decision_table_default = "<table>   <tbody>     <tr>       <td colspan=\"3\"> Table Name </td>     </tr>     <tr>       <td> #Description </td>       <td> Table Header 1 </td>       <td> Table Header 2? </td>     </tr>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";
        private static readonly string decision_table = "<table>   <tbody>     <tr>       <td colspan=\"3\"> decision:Table Name </td>     </tr>     <tr>       <td> #Description </td>       <td> Table Header 1 </td>       <td> Table Header 2? </td>     </tr>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";
        private static readonly string decision_table_with_theader = "<table>   <thead>     <tr>       <td colspan=\"3\"> Decision:Table Name </td>     </tr>     <tr>       <th> #Description </th>       <th> Table Header 1 </th>       <th> Table Header 2? </th>     </tr>   </thead>   <tbody>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";
        private static readonly string comment_decision_table = "<table>   <tbody>     <tr>       <td colspan=\"3\"> comment:Table Name </td>     </tr>     <tr>       <td> #Description </td>       <td> Table Header 1 </td>       <td> Table Header 2? </td>     </tr>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";
        private static readonly string setup_decision_table = "<table>   <tbody>     <tr>       <td colspan=\"3\"> setup:Table Name </td>     </tr>     <tr>       <td> #Description </td>       <td> Table Header 1 </td>       <td> Table Header 2? </td>     </tr>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";
        private static readonly string decision_table_with_decorations_in_headers = "<table>   <thead>     <tr>       <td colspan=\"3\"> Decision:Table Name </td>     </tr>     <tr>       <th> #<a href=\"#\" title=\"ignore_case\" data-href=\"#\">Description</a> </th>       <th> <a href=\"#\" title=\"ignore_case|ignore_all_spaces\" data-href=\"#\">Table Header 1</a> </th>       <th> <a href=\"#\" title=\"ignore_case|ignore_line_ending\" data-href=\"#\">Table Header 2</a>? </th>     </tr>   </thead>   <tbody>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";
        private static readonly string decision_table_with_decorations_in_th_headers = "<table>   <thead>     <tr>       <td colspan=\"3\"> Decision:Table Name </td>     </tr>     <tr>       <th> <a href=\"#\" title=\"ignore_case\" data-href=\"#\">#Description</a> </th>       <th> <a href=\"#\" title=\"ignore_case\" data-href=\"#\">Table Header 1</a> </th>       <th> <a href=\"#\" title=\"ignore_case|ignore_line_ending\" data-href=\"#\">Table Header 2?</a> </th>     </tr>   </thead>   <tbody>     <tr>       <td> Description </td>       <td> Table Data 1 </td>       <td> Table Data 2 </td>     </tr>   </tbody> </table> ";

        [Theory]
        [MemberData(nameof(get_test_data))]
        public void parse_header_decorations_tests(string decision_table, object[] input_header_info, object[] output_header_info, object comment_header_info)
        {
            (object[] input_header_info_output, object[] output_header_info_output, object comment_header_info_output) = parse_header_decorations_implementation(decision_table);
            Assert.Equal(input_header_info_output, input_header_info);
            Assert.Equal(output_header_info_output, output_header_info);
            Assert.Equal(comment_header_info_output, comment_header_info);
        }

        public static IEnumerable<object[]> get_test_data()
        {
            var data = new List<object[]>
            {
                new object[] { decision_table_default, null, null, null }, // No decorations defined
                new object[] { decision_table, null, null, null }, // No decorations defined
                new object[] { decision_table_with_theader, null, null, null }, // No decorations defined
                new object[] { comment_decision_table, null, null, null }, // No decorations defined
                new object[] { setup_decision_table, null, null, null }, // No decorations defined
                new object[] { decision_table_with_decorations_in_headers, new object[] {"ignore_case", "ignore_all_spaces"}, new object[] {"ignore_case", "ignore_line_ending"}, null }, // Decorations in comment headers ignored
                new object[] { decision_table_with_decorations_in_th_headers, new object[] {"ignore_case"}, new object[] {"ignore_case", "ignore_line_ending"}, null }, // Decorations in comment headers ignored
            };

            return data;
        }

        private partial (object[], object[], object) parse_header_decorations_implementation(string decision_table);

    }

    public partial class parse_decision_table_data_types
    {
        private static readonly string decision_table_data = "<table>   <tbody>     <tr>       <td colspan=\"3\"> Table Name </td>     </tr>     <tr>       <td> #String data </td>       <td> Integer data </td>       <td> Decimal data </td>       <td> Double data </td>       <td> Boolean data </td>       <td> DateTime data </td>     </tr>     <tr>       <td> Description </td>       <td> 12 </td>       <td> 12.5M </td>       <td> 12.5 </td>       <td> True </td>       <td> 2012-03-26 </td>     </tr>     <tr>       <td> Description </td>       <td> 12 </td>       <td> 12.5M </td>       <td> 12.5D </td>       <td> False </td>       <td> 2012-03-26 12:12:12</td>     </tr>     <tr>       <td> Description </td>       <td> 12 </td>       <td> 12M </td>       <td> 12D </td>       <td> false </td>       <td> 2012-03-26 12:12:12</td>     </tr>   </tbody> </table> ";

        [Theory]
        [MemberData(nameof(get_test_data))]
        public void parse_decision_table_data_types_tests(string decision_table, int row_no, string column_1, string column_2, string column_3, string column_4, string column_5, string column_6)
        {
            (string column_1_output, string column_2_output, string column_3_output, string column_4_output, string column_5_output, string column_6_output) = parse_decision_table_data_types_implementation(decision_table, row_no);
            Assert.Equal(column_1_output, column_1);
            Assert.Equal(column_2_output, column_2);
            Assert.Equal(column_3_output, column_3);
            Assert.Equal(column_4_output, column_4);
            Assert.Equal(column_5_output, column_5);
            Assert.Equal(column_6_output, column_6);
        }

        public static IEnumerable<object[]> get_test_data()
        {
            var data = new List<object[]>
            {
                new object[] { decision_table_data, 1, "string", "integer", "decimal", "double", "boolean", "datetime" }, // 
                new object[] { decision_table_data, 2, "string", "integer", "decimal", "double", "boolean", "datetime" }, // 
                new object[] { decision_table_data, 3, "string", "integer", "decimal", "double", "boolean", "datetime" }, // 
            };

            return data;
        }

        private partial (string, string, string, string, string, string) parse_decision_table_data_types_implementation(string decision_table, int row_no);

    }

    public partial class parse_decision_table_data
    {
        private static readonly string decision_table_data = "<table>   <tbody>     <tr>       <td colspan=\"3\"> Table Name </td>     </tr>     <tr>       <td> #String data </td>       <td> Integer data </td>       <td> Decimal data </td>       <td> Double data </td>       <td> Boolean data </td>       <td> DateTime data </td>     </tr>     <tr>       <td> Description </td>       <td> 12 </td>       <td> 12.5M </td>       <td> 12.5 </td>       <td> True </td>       <td> 2012-03-26 </td>     </tr>     <tr>       <td> Description </td>       <td> 12 </td>       <td> 12.5M </td>       <td> 12.5D </td>       <td> False </td>       <td> 2012-03-26 12:12:12</td>     </tr>     <tr>       <td> Description </td>       <td> 12 </td>       <td> 12M </td>       <td> 12D </td>       <td> false </td>       <td> 2012-03-26 12:12:12</td>     </tr>   </tbody> </table> ";

        [Theory]
        [MemberData(nameof(get_test_data))]
        public void parse_decision_table_data_tests(string decision_table, int row_no, string column_1, int column_2, decimal column_3, double column_4, bool column_5, DateTime column_6)
        {
            (string column_1_output, int column_2_output, decimal column_3_output, double column_4_output, bool column_5_output, DateTime column_6_output) = parse_decision_table_data_implementation(decision_table, row_no);
            Assert.Equal(column_1_output, column_1);
            Assert.Equal(column_2_output, column_2);
            Assert.Equal(column_3_output, column_3);
            Assert.Equal(column_4_output, column_4);
            Assert.Equal(column_5_output, column_5);
            Assert.Equal(column_6_output, column_6);
        }

        public static IEnumerable<object[]> get_test_data()
        {
            var data = new List<object[]>
            {
                new object[] { decision_table_data, 1, "Description", 12, 12.5M, 12.5D, true, new DateTime(2012, 3, 26, 0, 0, 0, 0) }, // 
                new object[] { decision_table_data, 2, "Description", 12, 12.5M, 12.5D, false, new DateTime(2012, 3, 26, 12, 12, 12, 0) }, // 
                new object[] { decision_table_data, 3, "Description", 12, 12, 12, false, new DateTime(2012, 3, 26, 12, 12, 12, 0) }, // 
            };

            return data;
        }

        private partial (string, int, decimal, double, bool, DateTime) parse_decision_table_data_implementation(string decision_table, int row_no);

    }

    public partial class parse_decision_table_data_types_with_variables
    {
        private static readonly string decision_table_variables = "<table>   <tbody>     <tr>       <td colspan=\"3\"> Table Name </td>     </tr>     <tr>       <td> #Column 1 </td>       <td> Column 2 </td>       <td> Column 3? </td>     </tr>     <tr>       <td> $variable_1 </td>       <td> 12 </td>       <td> $variable_2 </td>     </tr>     <tr>       <td> $variable_2 </td>       <td> $variable_1 </td>       <td> 12.5M </td>     </tr>     <tr>       <td> Description </td>       <td> $variable_2 </td>       <td> $variable_1 </td>     </tr>   </tbody> </table> ";

        [Theory]
        [MemberData(nameof(get_test_data))]
        public void parse_decision_table_data_types_with_variables_tests(string decision_table, int row_no, string column_1, string column_2, string column_3)
        {
            (string column_1_output, string column_2_output, string column_3_output) = parse_decision_table_data_types_with_variables_implementation(decision_table, row_no);
            Assert.Equal(column_1_output, column_1);
            Assert.Equal(column_2_output, column_2);
            Assert.Equal(column_3_output, column_3);
        }

        public static IEnumerable<object[]> get_test_data()
        {
            var data = new List<object[]>
            {
                new object[] { decision_table_variables, 1, "DecisionVariable", "integer", "DecisionVariable" }, // 
                new object[] { decision_table_variables, 2, "DecisionVariable", "DecisionVariable", "decimal" }, // 
                new object[] { decision_table_variables, 3, "string", "DecisionVariable", "DecisionVariable" }, // 
            };

            return data;
        }

        private partial (string, string, string) parse_decision_table_data_types_with_variables_implementation(string decision_table, int row_no);

    }

    public partial class parse_decision_table_data_with_variables
    {
        private static readonly string decision_table_variables = "<table>   <tbody>     <tr>       <td colspan=\"3\"> Table Name </td>     </tr>     <tr>       <td> #Column 1 </td>       <td> Column 2 </td>       <td> Column 3? </td>     </tr>     <tr>       <td> $variable_1 </td>       <td> 12 </td>       <td> $variable_2 </td>     </tr>     <tr>       <td> $variable_2 </td>       <td> $variable_1 </td>       <td> 12.5M </td>     </tr>     <tr>       <td> Description </td>       <td> $variable_2 </td>       <td> $variable_1 </td>     </tr>   </tbody> </table> ";

        [Theory]
        [MemberData(nameof(get_test_data))]
        public void parse_decision_table_data_with_variables_tests(string decision_table, int row_no, string column_1, object column_2, object column_3)
        {
            (string column_1_output, object column_2_output, object column_3_output) = parse_decision_table_data_with_variables_implementation(decision_table, row_no);
            Assert.Equal(column_1_output, column_1);
            Assert.Equal(column_2_output, column_2);
            Assert.Equal(column_3_output, column_3);
        }

        public static IEnumerable<object[]> get_test_data()
        {
            var data = new List<object[]>
            {
                new object[] { decision_table_variables, 1, null, 12, null }, // 
                new object[] { decision_table_variables, 2, null, null, 12.5M }, // 
                new object[] { decision_table_variables, 3, "Description", null, null }, // 
            };

            return data;
        }

        private partial (string, object, object) parse_decision_table_data_with_variables_implementation(string decision_table, int row_no);

    }

}