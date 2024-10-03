using System;

class Student {
    private string name;
    private int age;

    public Student(string name, int age){
        this.name = name;
        this.age = age;
    }

    public void getName(){
        Console.WriteLine(this.name);
    }

    public static void printStudents(Student[] students){
        foreach(var student in students){
            student.getName();
        }
    }

    public static void printStudentsLinq(Student[] students){
        var oldestStudent = from student in students
                        where student.age == 45
                        select student;

        foreach(var student in oldestStudent){
            Console.WriteLine(student.name);
        }

    }
}

class Example {
    static void Main(){
        Student[] Students = new Student[] { 
            new Student("Alice", 21), 
            new Student("Bob", 32),
            new Student("Tom", 27),
            new Student("Richard", 45)
        };

        Student.printStudentsLinq(Students);
    }
}