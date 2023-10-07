namespace GenericSample
{
    public class Client<T>
    {
        public T ClientCode;
        public string Name;

        public Client(T clientCode, string name)
        {
            ClientCode = clientCode;
            Name = name;
        }
    }

}
