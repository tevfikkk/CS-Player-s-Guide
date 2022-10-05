class Door
{
    public DoorState State { get; private set; } = DoorState.Close;
    public int CurrentCode { get; private set; }

    public Door(int code) => CurrentCode = code;

    public bool Open()
    {
        if (State == DoorState.Close)
        {
            State = DoorState.Open;
            return true;
        }
        return false;
    }

    public void Close()
    {
        if (State == DoorState.Open)
        {
            State = DoorState.Close;
        }
    }

    public void Lock()
    {
        if (State == DoorState.Close)
        {
            State = DoorState.Lock;
        }
    }

    public void Unlock(int code)
    {
        if (State == DoorState.Lock && code == CurrentCode)
        {
            State = DoorState.Close;
        }
    }

    public bool ChangeCode(int currentCode, int newCode)
    {
        if (currentCode == CurrentCode)
        {
            CurrentCode = newCode;
            return true;
        }
        return false;
    }

}


enum DoorState
{
    Open,
    Close,
    Lock
}