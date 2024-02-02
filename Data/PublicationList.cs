using PersonalWebsite.Data.Entities;

namespace PersonalWebsite.Data;

public class PublicationList
{
    public readonly Publication[] Publications =
    [
        new Publication
        {
            Authors = [
                new("Peterson", "Yuhala"),
                Author.Me, 
                Author.PascalFelber,
                Author.MarceloPasin, 
                Author.ValerioSchiavoni
            ],
            ConferenceAbbreviation = "SAC'24",
            ConferenceEditionNumber = 39,
            ConferenceName = "ACM/SIGAPP Symposium On Applied Computing",
            Date = new(2023, 12, 01),
            Doi = "10.1145/3605098.3635994",
            Title = "Fortress: Securing IoT Peripherals with Trusted Execution Environments",
            LinkToArxiv = new("https://arxiv.org/abs/2312.02542"),
            LinkToConference = new("https://www.sigapp.org/sac/sac2024/")
        },
        new Publication
        {
            Authors = [
                Author.Me,
                Author.MarceloPasin,
                Author.PascalFelber,
                Author.ValerioSchiavoni, 
                new("Giovanni", "Mazzero"),
                new("Arne", "Hollum"),
                new("Darshan", "Vaydia")
            ],
            ConferenceAbbreviation = "TDSC",
            ConferenceEditionNumber = 0,
            ConferenceName = "IEEE Transactions on Dependable and Secure Computing",
            Date = new(2023, 11, 01),
            Doi = "10.1109/TDSC.2023.3334516",
            IsInfluential = true,
            Title = "A Comprehensive Trusted Runtime for WebAssembly with Intel SGX",
            LinkToCode = new("https://github.com/JamesMenetrey/unine-twine"),
            LinkToJournal = new("https://www.computer.org/csdl/journal/tq/5555/01/10323228/1SewYRI4Rd6")
        },
        new Publication
        {
            Authors =
            [
                Author.Me,
                new("Aeneas", "Grüter"),
                new("Peterson", "Yuhala"),
                new("Julius", "Oeftiger"),
                Author.PascalFelber,
                Author.MarceloPasin,
                Author.ValerioSchiavoni
            ],
            ConferenceAbbreviation = "OPODIS'23",
            ConferenceEditionNumber = 0,
            ConferenceName = "Conference on Principles of Distributed Systems",
            Date = new(2023, 12, 01),
            Doi = "10.4230/LIPIcs.OPODIS.2023.23",
            Title = "A Holistic Approach for Trustworthy Distributed Systems with WebAssembly and TEEs",
            LinkToArxiv = new("https://arxiv.org/abs/2312.00702"),
            LinkToCode = new("https://github.com/JamesMenetrey/unine-opodis2023"),
            LinkToConference = new("https://xdefago.github.io/opodis23/")
        },
        new Publication
        {
            Authors =
            [
                new("Pascal", "Gerig"),
                Author.Me,
                new("Baptiste", "Lanoix"),
                new("Florian", "Stoller"),
                Author.PascalFelber,
                Author.MarceloPasin,
                Author.ValerioSchiavoni
            ],
            ConferenceAbbreviation = "DEBS'23",
            ConferenceEditionNumber = 17,
            ConferenceName = "ACM International Conference on Distributed and Event-Based Systems",
            Date = new(2023, 06, 01),
            Doi = "10.1145/3583678.3596899",
            Title = "Preventing EFail Attacks with Client-Side WebAssembly: The Case of Swiss Post's IncaMail",
            LinkToConference = new("https://2023.debs.org/"),
            LinkToArxiv = new("https://arxiv.org/abs/2306.13388")
        },
        new Publication
        {
            Authors =
            [
                Author.Me,
                Author.MarceloPasin,
                Author.PascalFelber,
                Author.ValerioSchiavoni
            ],
            ConferenceAbbreviation = "ICDCS'22",
            ConferenceEditionNumber = 42,
            ConferenceName = "IEEE International Conference on Distributed Computing Systems",
            Date = new(2022, 07, 01),
            Doi = "10.1109/ICDCS54860.2022.00116",
            IsInfluential = true,
            Title = "WaTZ: A Trusted WebAssembly Runtime Environment with Remote Attestation for TrustZone",
            LinkToArxiv = new("https://arxiv.org/abs/2206.08722"),
            LinkToConference = new("https://icdcs2022.icdcs.org/"),
            LinkToCode = new("https://github.com/JamesMenetrey/unine-watz")
        },
        new Publication
        {
            Authors =
            [
                Author.Me,
                Author.MarceloPasin,
                Author.PascalFelber,
                Author.ValerioSchiavoni
            ],
            ConferenceAbbreviation = "FRAME'22",
            ConferenceEditionNumber = 2,
            ConferenceName = "Flexible Resource and Application Management on the Edge",
            Date = new(2022, 06, 01),
            Doi = "10.1145/3526059.3533618",
            Title = "WebAssembly as a common layer for the cloud-edge continuum",
            LinkToArxiv = new("https://arxiv.org/abs/2206.12888"),
            LinkToConference = new("https://www.accordion-project.eu/frame-2nd-workshop-on-flexible-resource-and-application-management-on-the-edge/")
        },
        new Publication
        {
            Authors =
            [
                Author.Me,
                new("Christian", "Göttel"),
                new("Anum", "Khurshid"),
                Author.MarceloPasin,
                Author.PascalFelber,
                Author.ValerioSchiavoni,
                new("Shahid", "Raza")
            ],
            ConferenceAbbreviation = "DAIS'22",
            ConferenceEditionNumber = 22,
            ConferenceName = "IFIP International Conference on Distributed Applications and Interoperable Systems",
            Date = new(2022, 06, 01),
            Doi = "10.1007/978-3-031-16092-9_7",
            Title = "Attestation Mechanisms for Trusted Execution Environments Demystified",
            LinkToArxiv = new("https://arxiv.org/abs/2206.03780"),
            LinkToConference = new("https://www.discotec.org/2022/dais")
        },
        new Publication
        {
            Authors =
            [
                Author.Me,
                new("Christian", "Göttel"),
                Author.MarceloPasin,
                Author.PascalFelber,
                Author.ValerioSchiavoni,
            ],
            ConferenceAbbreviation = "SysTEX'22",
            ConferenceEditionNumber = 5,
            ConferenceName = "Workshop on System Software for Trusted Execution",
            Date = new(2022, 03, 01),
            Title = "An Exploratory Study of Attestation Mechanisms for Trusted Execution Environments",
            LinkToArxiv = new("https://arxiv.org/abs/2204.06790"),
            LinkToConference = new("https://www.discotec.org/2022/dais")
        },
        new Publication
        {
            Authors =
            [
                new("Peterson", "Yuhala"),
                Author.Me,
                Author.PascalFelber,
                Author.ValerioSchiavoni,
                new("Alain", "Tchana"),
                new("Gaël", "Thomas"),
                new("Hugo", "Guiroux"),
                new("Jean-Pierre", "Lozi")
            ],
            ConferenceAbbreviation = "Middleware'21",
            ConferenceEditionNumber = 22,
            ConferenceName = "ACM/IFIP Middleware",
            Date = new(2021, 12, 01),
            Doi = "10.1145/3464298.3493406",
            Title = "Montsalvat: Intel SGX Shielding for GraalVM Native Images",
            LinkToArxiv = new("https://arxiv.org/abs/2305.00766"),
            LinkToCode = new ("https://github.com/Yuhala/montsalvat"),
            LinkToConference = new("https://middleware-conf.github.io/2021/")
        },
        new Publication
        {
            Authors =
            [
                Author.Me,
                Author.MarceloPasin,
                Author.PascalFelber,
                Author.ValerioSchiavoni,
            ],
            ConferenceAbbreviation = "ICDE'21",
            ConferenceEditionNumber = 37,
            ConferenceName = "IEEE International Conference on Data Engineering",
            Date = new(2021, 04, 01),
            Doi = "10.1109/ICDE51399.2021.00025",
            IsInfluential = true,
            Title = "Twine: An Embedded Trusted Runtime for WebAssembly",
            LinkToArxiv = new("https://arxiv.org/abs/2103.15860"),
            LinkToCode = new("https://github.com/JamesMenetrey/unine-twine"),
            LinkToConference = new("https://icde2021.gr/")
        }
    ];

    public IEnumerable<Publication> GetPublications(bool even)
    {
        return Publications.Where((t, i) => i % 2 == (even ? 0 : 1));
    }
}