namespace Sharemee.Toolkit.Entity;

public interface ICreateTime
{
    DateTime CreateTime { get; set; }
}

public interface IUpdateTime
{
    DateTime? UpdateTime { get; set; }
}

public interface ICreateUpdateTime : ICreateTime, IUpdateTime
{
}