using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Postman : MonoBehaviour {
    private void Start()
    {
        
    }
    IEnumerator getList()
    {
        yield return null;
    }
}
public class Info
{
    public string _postman_id { get; set; }
    public string name { get; set; }
    public string schema { get; set; }
}

public class ProtocolProfileBehavior
{
    public bool disableBodyPruning { get; set; }
}

public class Formdata
{
    public string key { get; set; }
    public string value { get; set; }
    public string type { get; set; }
}

public class Body
{
    public string mode { get; set; }
    public List<Formdata> formdata { get; set; }
}

public class Request
{
    public string method { get; set; }
    public List<object> header { get; set; }
    public Body body { get; set; }
    public object url { get; set; }
}

public class Item
{
    public string name { get; set; }
    public string id { get; set; }
    public ProtocolProfileBehavior protocolProfileBehavior { get; set; }
    public Request request { get; set; }
    public List<object> response { get; set; }
}

public class Script
{
    public string id { get; set; }
    public string type { get; set; }
    public List<string> exec { get; set; }
}

public class Event
{
    public string listen { get; set; }
    public Script script { get; set; }
}

public class Root
{
    public Info info { get; set; }
    public List<Item> item { get; set; }
    public List<Event> @event { get; set; }
}


