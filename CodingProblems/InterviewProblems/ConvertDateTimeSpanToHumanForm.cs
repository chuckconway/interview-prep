namespace CodingProblems.InterviewProblems;

/// <summary>
/// Your client has asked you to add a feature to his website that will show the time elapsed since a blog
// post was added.
//     Write a method that formats the time difference. The difference is counted in minutes if the post was
//     published less than an hour ago or in hours if the post was published at least an hour ago. After 1
// day passes, the difference is counted in days. After 7 days since publication, just the full date is
//     shown (eg. 2018-10-10 22:05).
// For example:
// If the post was published at 11:30 and it's 11:40, then it was published 10 minutes(s) ago.
//     If the post was published at 11:30 and it's 12:30, then it was published 1 hour (s) ago.
//     If the post was published at 11:30 and it's 23:30, then it was published 12 hour(s) ago.
//     If the post was published at 8:00 and it's 8:00 the next day, then it was published 1 day (s) ago.
//     If the post was published at 8:00 and it's 8:00 the same day, then it was published now.
//     For the implementation, use the provided class:
// public class DateTimeToHumanReadableFormFormatter
// {
//     public string Format (DateTime date, DateTime current) (}
// }
// Example use case:
// var formatter = new DateTimeToHumanReadableFormFormatter();
// var val = formatter.Format (DateTime.Now.AddDays(-1), DateTime.Now);
// Example formatting outputs:
// noW
// 1 minute(s) ago
// 5 minute(s) ago
// 1 hour (s) ago
// 13 hour (s) ago
// 1 day(s) ago
// 4 day(s) ago
// 2018-10-10 22:05
/// </summary>
public class ConvertDateTimeSpanToHumanForm
{
    
}