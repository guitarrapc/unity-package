using System.Collections;
using System.Collections.Generic;

public class Message
{
    public string Text { get; set; }
    public string Version { get; set; }

    public string GetMessage()
    {
        return Text + ":" + Version;
    }
}