using System.Collections.Generic;
using DataLayer.Entity;
namespace ServiceLayer
{
    public interface IPartsService
    {
        int PartCount { get; set; }
        Dictionary<int, Part> Parts { get; }
        Part GetPart(int partID);
        void LoadParts();
    }
}