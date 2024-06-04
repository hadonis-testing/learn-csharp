namespace CS04
{
    class DuLieuNhap : EventArgs
    {
        public int data { get; set; }

        public DuLieuNhap(int x) => data = x;
    }

    class UserInput
    {
        public event EventHandler sukienNhapso;

        public void Input()
        {
            string? s = Console.ReadLine();
            int i = int.Parse(s != null ? s : string.Empty);

            sukienNhapso?.Invoke(this, new DuLieuNhap(i));
        }
    }
}
