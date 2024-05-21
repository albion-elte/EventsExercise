using EventsExercise;

Student student = new("Studenti");
Console.WriteLine($"Hello, {student.Name}");
student.ReachedRegistrationLimit += RegisterSubject;

List<Subject> subjects = new List<Subject>()
{ 
    new Subject {SubjectId = 1, SubjectName = "Sub1"},
    new Subject {SubjectId = 2, SubjectName = "Sub2"},
    new Subject {SubjectId = 3, SubjectName = "Sub3"},
    new Subject {SubjectId = 4, SubjectName = "Sub4"},
    new Subject {SubjectId = 5, SubjectName = "Sub5"},
    new Subject {SubjectId = 16, SubjectName = "Sub6"},
};


foreach (Subject subject in subjects )
{
    student.RegisteredSubjects.Add(subject);
    student.RegisterSubject();
    Console.WriteLine("Subject registered successfully");

    Console.WriteLine("Do you want to continue to register another subject? Yes/No");
    var continueRegistration = Console.ReadLine();
    if (continueRegistration.ToLower() == "no")
        break;
}


static void RegisterSubject(object? sender, EventArgs e)
{
    if (sender is null) return;
    Console.WriteLine("You are allowed to register at most 3 subjects.");
}