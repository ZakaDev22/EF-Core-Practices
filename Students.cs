namespace EF_Core_Practices
{
    public class Students
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Grade { get; set; }
        public bool IsActive { get; set; }

        public override string ToString()
        {
            return $" ID : [{StudentID}] , Name : {Name} , Subject : {Subject} , Grade : {Grade} , Is Active : {IsActive}";
        }
    }
}
