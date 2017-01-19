namespace ListGroup
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public string ShortName
        {
            get { return FirstName[0] + LastName[0].ToString(); }
        }

        public string Inicial
        {
            get { return FirstName[0].ToString(); }
        }
    }
}
