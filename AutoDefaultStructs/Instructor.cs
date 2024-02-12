namespace AutoDefaultStructs
{
    public struct Instructor
    {
        public int FacultyID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Instructor(string name)
        {
            Name = name;
        }
    }
}
