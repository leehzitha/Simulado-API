using simulado.Models;

namespace simulado.UseCases.ReadList.FindReadList;

public record FindReadListResponse (
    string Title,
    DateTime LastMod,
    IEnumerable<ReadListData> FanficList
);