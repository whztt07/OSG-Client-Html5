//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: model.proto
namespace proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TaskConfig")]
  public partial class TaskConfig : global::ProtoBuf.IExtensible
  {
    public TaskConfig() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private string _Name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private int _Type;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Type
    {
      get { return _Type; }
      set { _Type = value; }
    }
    private int _ActivityType;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ActivityType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ActivityType
    {
      get { return _ActivityType; }
      set { _ActivityType = value; }
    }
    private string _Describe = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Describe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Describe
    {
      get { return _Describe; }
      set { _Describe = value; }
    }
    private int _Progress;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Progress", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Progress
    {
      get { return _Progress; }
      set { _Progress = value; }
    }
    private int _Reward;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Reward", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Reward
    {
      get { return _Reward; }
      set { _Reward = value; }
    }
    private int _NextTask;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"NextTask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int NextTask
    {
      get { return _NextTask; }
      set { _NextTask = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}