using EdNexusData.Broker.Common.EducationOrganizations;
using EdNexusData.Broker.Common.Importer;
using EdNexusData.Broker.Common.Students;

namespace EdNexusData.Broker.Common;

public interface ITransformer<IT, RT>
{
    public RT Map(
        IT objectToMap, 
        Student student, 
        EducationOrganization educationOrganization,
        Manifest manifest
    );
}