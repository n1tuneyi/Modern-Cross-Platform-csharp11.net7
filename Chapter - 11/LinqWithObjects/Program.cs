﻿//string[] names = new[] { "Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed" };

//SectionTitle("Deferred execution");

//var query1 = names.Where(name => name.EndsWith("m"));

//var query2 = from name in names where name.EndsWith("m") select name;

//var query = names.Where(name => name.Length > 4)
//                 .OrderBy(name => name.Length)
//                 .ThenBy(name => name);

//string[] result1 = query1.ToArray();

//List<string> result2 = query2.ToList();

//foreach (string name in query)
//{
//    WriteLine(name);
//    //names[2] = "Jimmy";
//}


//SectionTitle("Filtering by type");
//List<Exception> exceptions = new()
//{
//    new ArgumentException(),
//    new SystemException(),
//    new IndexOutOfRangeException(),
//    new InvalidOperationException(),
//    new NullReferenceException(),
//    new InvalidCastException(),
//    new OverflowException(),
//    new DivideByZeroException(),
//    new ApplicationException()
//};

//IEnumerable<ArithmeticException> arithmeticExceptionsQuery =
//                    exceptions.OfType<ArithmeticException>();

//foreach (ArithmeticException exception in arithmeticExceptionsQuery)
//{
//    WriteLine(exception);
//}

using System.Linq;

string[] cohort1 = new[]
                        { "Rachel", "Gareth", "Jonathan", "George" };
string[] cohort2 = new[]
                        { "Jack", "Stephen", "Daniel", "Jack", "Jared" };
string[] cohort3 = new[]
                        { "Declan", "Jack", "Jack", "Jasmine", "Conor" };

SectionTitle("The cohorts");
Output(cohort1, "Cohort 1");
Output(cohort2, "Cohort 2");
Output(cohort3, "Cohort 3");

SectionTitle("Set operations");
Output(cohort2.Distinct(), "cohort2.Distinct()");
Output(cohort2.DistinctBy(name => name.Substring(0, 2)), "cohort2.DistinctBy(name => name.Substring(0, 2)):");
Output(cohort2.Union(cohort3), "cohort2.Union(cohort3)");
Output(cohort2.Concat(cohort3), "cohort2.Concat(cohort3)");
Output(cohort2.Intersect(cohort3), "cohort2.Intersect(cohort3)");
Output(cohort2.Except(cohort3), "cohort2.Except(cohort3)");
Output(cohort1.Zip(cohort2, (c1, c2) => $"{c1} matched with {c2}"),
"cohort1.Zip(cohort2)");