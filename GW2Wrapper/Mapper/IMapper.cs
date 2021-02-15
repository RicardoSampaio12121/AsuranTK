using GW2Wrapper.Connector;

namespace GW2Wrapper.Mapper
{
    public interface IMapper
    {
        T MapTop<T>(string toMap);
    }
}