namespace WebApplication1.Services
{
    public class Calculate
    {
        public Calculate(int initVal)
        {
            Value = initVal; 
        }

        public int Value { get; set; }

        public void Add(int value)
        {
            this.Value += value;
        }
        public void Decrease(int value)
        {
            this.Value -= value;
        }

        public int GetValue()
        {
            return Value;
        }

        //  private int _valuel;
        // public int Valuel 
        // {
        //     get => this._value;
        //     set=>this._value = value;
        // }
        // public void SetValue(int value)
        // {
        //     this.Valuel = value;
        // }

    }
}
