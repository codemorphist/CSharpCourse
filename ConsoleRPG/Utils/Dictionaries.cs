using System;
using System.Security.Policy;

namespace ConsoleRPG.Utils
{
    static class Dictionaries
    {
        // Dicctionary for random names
        public static readonly string[] nm1 =
        {
            "Acanthuridae", "Achatina", "Achatinoidea", "Acinonyx", "Actinidia", "Aegypius", "Aepyceros", "Ailuropoda",
            "Ailurus", "Ajaja", "Alcelaphinae", "Alces", "Alligator", "Alopex", "Alouatta", "Ambystoma",
            "Amphiprioninae", "Anas", "Anguis", "Anisoptera", "Anthozoa", "Apatura", "Apis", "Apodemus", "Aptenodytes",
            "Arachnocampa", "Arctictis", "Arctocephalinae", "Ardeidae", "Arini", "Arvicola", "Astrochelys", "Atelerix",
            "Balaenoptera", "Balsenoptera", "Barbus", "Betta", "Bison", "Blattaria", "Bombina", "Bombus", "Bos",
            "Brachypelma", "Brachyura", "Branta", "Bubalus", "Bubo", "Bufo", "Buteo", "Cacajao", "Caelifera",
            "Caimaninae", "Callithrix", "Camelus", "Canis", "Canus", "Capra", "Caracal", "Carcharhinus", "Carcharodon",
            "Caridea", "Castor", "Casuarius", "Caudata", "Cavia", "Cebus", "Cephalopterus", "Ceratophrys",
            "Ceratotherium", "Cerura", "Cetorhinus", "Cettia", "Chaetodontidae", "Chamaeleonidae", "Chelonioidea",
            "Chelydridae", "Chilopoda", "Chinchilla", "Chiroptera", "Chlamydosaurus", "Chlamyphorus", "Chlorocebus",
            "Choeropsis", "Choloepus", "Cichlidae", "Cirripedia", "Civettictis", "Cnidaria", "Coccinellidae",
            "Coleoptera", "Connochaetes", "Coraciiformes", "Coturnix", "Crocodylus", "Crocuta", "Cryptoprocta", "Cuon",
            "Cygnus", "Dasyatis", "Dasypodidae", "Dasyurus", "Daubentonia", "Delphinus", "Demospongiae", "Dendrobatidae",
            "Dendrobranchiata", "Dermaptera", "Desmodontinae", "Dicerorhinus", "Diceros", "Didelphis", "Diomedeidae",
            "Diplopoda", "Diptera", "Dracaena", "Dromaius", "Dugong", "Dynastes", "Echinoidea", "Electrophorus",
            "Elephantulus", "Elephas", "Eleutherodactylus", "Emydidae", "Enhydra", "Ephemeroptera", "Equus", "Erethizon",
            "Erithacus", "Erythrocebus", "Esox", "Eudyptes", "Eudyptula", "Euptilotis", "Falconiforme", "Felis",
            "Formicidae", "Fratercula", "Fregata", "Funambulus", "Galeocerdo", "Gallinula", "Gallus", "Gavia",
            "Gavialis", "Gekkonidae", "Geochelone", "Gerbillinae", "Gerridae", "Ginglymostoma", "Giraffa", "Gliridae",
            "Gopherus", "Gorilla", "Gruidae", "Gulo", "Gynnidomorpha", "Halichoerus", "Helarctos", "Heleioporus",
            "Heloderma", "Helogale", "Hemigalus", "Heterodontus", "Hieraatus", "Hippocampus", "Hippopotamus",
            "Holothuroidea", "Homo", "Hydrochoerus", "Hydrodamalis", "Hydrurga", "Hyla", "Hylobatidae", "Hymenoptera",
            "Iguana", "Indri", "Insecta", "Isoptera", "Labridae", "Lacerta", "Lacertilia", "Lagenorhynchus", "Lagothrix",
            "Lama", "Larva", "Latrodectus", "Lemmus", "Lemur", "Leontopithecus", "Leopardus", "Lepisosteidae",
            "Leptailurus", "Lepus", "Limulidae", "Lissotriton", "Litoria", "Lopholithodes", "Loxodonta", "Lucanidae",
            "Luscinia", "Lutra", "Lycaon", "Lynx", "Macaca", "Macropus", "Mammuthus", "Mandrillus", "Manta",
            "Megadyptes", "Megaptera", "Meleagris", "Melopsittacus", "Mephitis", "Merops", "Mesobatrachia",
            "Mesocricetus", "Metynnis", "Microcebus", "Mirounga", "Moloch", "Muraenidae", "Mustela", "Myrmecobius",
            "Myrmecophaga", "Nandinia", "Nasalis", "Nasua", "Nectophryne", "Neofelis", "Nephropidae", "Numididae",
            "Nyctereutes", "Ochotona", "Octopus", "Odobenus", "Odocoileus", "Okapia", "Oniscidea", "Ophisaurus",
            "Orcinus", "Oriolus", "Ornithorhynchus", "Oryctolagus", "Osteolaemus", "Ostreidae", "Otariidae", "Ovis",
            "Paguma", "Paguroidea", "Pan", "Panthera", "Papilionoidea", "Papio", "Paracheirodon", "Paradisaeidae",
            "Paradoxurus", "Paralichthys", "Passeridae", "Pavo", "Pecari", "Pelecanus", "Pelophylax", "Perameles",
            "Phacochoerus", "Phaethon", "Phalanger", "Phalangeriforme", "Pharomachrus", "Phascolarctos", "Phasianus",
            "Phasmatodea", "Phoca", "Phoenicopterus", "Phycodurus", "Physeter", "Physignathus", "Pica", "Picidae",
            "Platanistoidea", "Poecilia", "Pogona", "Pomacanthidae", "Pongo", "Prionailurus", "Pristella", "Procavia",
            "Procyon", "Proteus", "Protoreaster", "Pseudoryx", "Psittacine", "Pterois", "Pteromyini", "Pygocentrus",
            "Pygoscelis", "Ramphastos", "Rana", "Rangifer", "Raphus", "Rattus", "Recurvirostra", "Rhincodon",
            "Rhinoceros", "Rhinocerotidae", "Rhinoderma", "Rupicapra", "Saguinus", "Saimiri", "Sarcophilus", "Sciuridae",
            "Scorpaenidae", "Scorpiones", "Sepiida", "Serpentes", "Setonix", "Siluriformes", "Simia", "Smilodon",
            "Spermophilus", "Spheniscus", "Sphenodon", "Sphyraena", "Sphyrna", "Squalus", "Stegostoma", "Strigops",
            "Strix", "Struthio", "Sula", "Suricata", "Sus", "Symphysodon", "Syncerus", "Tachyglossus", "Talpidae",
            "Tamias", "Tapirus", "Tarsius", "Taxidea", "Tetraodontidae", "Tetraoninae", "Teuthida", "Threskiornithidae",
            "Thylogale", "Tragelaphus", "Tremarctos", "Trichechus", "Tridacna", "Trochilidae", "Troglodytes", "Tursiops",
            "Tyto", "Urochordata", "Uroplatus", "Ursidae", "Ursus", "Varanus", "Vespa", "Viverra", "Vombatus", "Vulpes",
            "Xenopus"
        };
        public static readonly string[] nm2 =
        {
            "abelii", "acanthias", "aculeatus", "acutorostrata", "adeliae", "aegagrus", "afra", "africana", "africanus",
            "agassizii", "agilis", "ajaja", "alba", "albiventris", "alces", "alisman", "alpinus", "altaica", "aluco",
            "amblyrhynchos", "americanus", "amoyensis", "amphibius", "anatinus", "anguinus", "antarcticus", "antipodes",
            "arctica", "arcticus", "arctos", "argenteus", "aries", "asinus", "atratus", "auratus", "aurelia", "aureus",
            "axelrodi", "bactrianus", "barbus", "bengalensis", "berengei", "bicolor", "bicornis", "binotata",
            "binturong", "birostris", "bison", "borneensis", "brachyurus", "bubalis", "bufo", "buteo", "caballus",
            "caffer", "camelopardalis", "camelus", "canadensis", "capensis", "capucinus", "caracal", "carcharias",
            "catesbeiana", "catta", "centroura", "chrysocome", "chrysolophus", "cinereus", "cirratum", "civetta",
            "colchicus", "concolor", "corbetti", "coturnix", "cristatus", "crocuta", "cucullatus", "cuniculus", "cuvier",
            "cyclotis", "darwinii", "deliciosa", "delphis", "demersus", "derbyanus", "diehli", "dingo", "diphone",
            "domesticus", "dorsaum", "dromedarius", "dugon", "electricus", "elegans", "eques", "equus", "erminea",
            "esculentus", "europaeus", "eurycerus", "falconeri", "familiaris", "fasciatum", "fasciatus", "fascicularis",
            "ferox", "forsteri", "fragilis", "francisci", "fulgens", "fulica", "furo", "fuscata", "gallus", "gangeticus",
            "geoffroyi", "gigantea", "giganteus", "gigas", "glama", "gorilla", "graueri", "grevyi", "grunniens",
            "grypus", "guianensis", "gulo", "habroptilus", "harrisii", "hercules", "hermaphroditus", "hircus",
            "hoffmani", "horriblis", "horridus", "humboldti", "hydrochaeris", "iberia", "iguana", "immer", "imperator",
            "indicus", "indri", "iris", "jacksoni", "johnstoni", "jubatus", "kingii", "komodoensis", "laevis", "lagopus",
            "lagotricha", "lanigera", "larvata", "larvatus", "latrans", "lemmus", "leo", "leptonyx", "lessonae",
            "leucas", "liberiensis", "lotor", "luminosa", "lupus", "lutris", "lynx", "macrocephalus", "maculatus",
            "magarhynchos", "magellanicus", "malayanus", "manatu", "mandarinia", "mandtii", "marinus", "maritimus",
            "maxillaris", "maximus", "melampus", "melanoleuca", "mendiculus", "mephitis", "mexicanum", "midas", "minor",
            "monachus", "mule", "murinus", "musculus", "nasua", "nasuta", "nattereri", "neanderthalensis", "nebouxii",
            "nebulosa", "nghetinhensis", "nigra", "nivalis", "nodosus", "novaeangliae", "novaehollandiae", "obscurus",
            "occidentalis", "oedipus", "onca", "orca", "orientalis", "oriolus", "ornata", "ornatus", "palmarum",
            "paniscus", "papua", "pardalis", "pardus", "parvula", "patagonicus", "patas", "physalus", "pica", "pictus",
            "platyrhynchos", "populator", "porcellus", "primigenius", "procyonoides", "punctatus", "putorius",
            "pygerythrus", "pygmaea", "pygmaeus", "quagga", "radiata", "rattus", "reticulata", "richardsonii",
            "ridibundus", "robustus", "rosalia", "rosmarus", "rubecula", "rufus", "rupicapra", "sapiens", "scandiacus",
            "schlegeli", "scrofa", "scyphozoa", "serval", "simum", "smithi", "sondaicus", "sphinx", "spilogaster",
            "splendens", "strepsiceros", "striatus", "sulfuratus", "sumatrae", "sumatranus", "sumatrensis", "suricatta",
            "suspectum", "sylvaticus", "tajacu", "tangalunga", "tarandus", "taurinus", "taurus", "taxus", "temporaria",
            "tetraspis", "tibetanus", "tigrinum", "tigris", "toco", "tridactyla", "troglodytes", "truncatus", "typus",
            "undulatus", "unicornis", "ursinus", "vinula", "virginiana", "vitticeps", "vitulina", "viverrinus",
            "volitans", "vulgaris", "vulpes", "zebra", "zerda", "zygaena"
        };
        public static readonly string[] nm3 =
        {
            "Acanth", "Ach", "Achat", "Acin", "Act", "Aeg", "Aepyc", "Ail", "Ailur", "Aj", "Al", "Alc", "Alcel", "All",
            "Amb", "Amphipr", "An", "Ang", "Anis", "Anth", "Ap", "Apat", "Apod", "Apten", "Ar", "Arachn", "Arct",
            "Arctoc", "Ard", "Arv", "Astr", "Atel", "Balaen", "Balsen", "Barb", "Bett", "Bis", "Blatt", "Bomb", "Bos",
            "Br", "Brach", "Bub", "Buf", "But", "Cac", "Cael", "Caim", "Call", "Cam", "Can", "Capr", "Car", "Carch",
            "Cas", "Cast", "Caud", "Cav", "Ceb", "Cephal", "Cer", "Cerat", "Cet", "Cett", "Chaetod", "Chamael", "Chel",
            "Chelon", "Chil", "Chinch", "Chiropt", "Chlam", "Chlamyd", "Chlor", "Choer", "Chol", "Cichl", "Cirr",
            "Civett", "Cnid", "Coccin", "Coleopt", "Connoch", "Corac", "Cot", "Croc", "Crocod", "Crypt", "Cuon", "Cygn",
            "Das", "Dasyp", "Daubent", "Delph", "Demosp", "Dendrob", "Dendrobr", "Derm", "Desmod", "Dic", "Dicer", "Did",
            "Diom", "Dipl", "Dipt", "Drac", "Drom", "Dug", "Dyn", "Echin", "Electr", "Eleph", "Eleuther", "Emyd", "Enh",
            "Ephem", "Eq", "Ereth", "Erith", "Erythr", "Es", "Eud", "Eupt", "Falcon", "Fel", "Formic", "Frat", "Freg",
            "Fun", "Galeoc", "Gall", "Gallin", "Gav", "Gekkon", "Geoch", "Gerb", "Gerr", "Ginglym", "Gir", "Glir",
            "Goph", "Gor", "Gruid", "Gul", "Gynnid", "Halich", "Hel", "Heleiop", "Helod", "Helog", "Hemig", "Heter",
            "Hier", "Hipp", "Hippop", "Holoth", "Hom", "Hydr", "Hydrod", "Hyl", "Hylob", "Hymen", "Iguan", "Indr", "Ins",
            "Isopt", "Labr", "Lac", "Lacert", "Lag", "Lagenorh", "Lam", "Larv", "Latr", "Lem", "Lemm", "Leontop", "Leop",
            "Lep", "Lepis", "Lept", "Limul", "Liss", "Lit", "Lophol", "Loxod", "Lucan", "Lusc", "Lutr", "Lyc", "Lynx",
            "Mac", "Macr", "Mammuth", "Mandr", "Mant", "Megad", "Megapt", "Meleagr", "Melops", "Meph", "Mer", "Mesobatr",
            "Mesocr", "Met", "Microc", "Mir", "Mol", "Muraen", "Must", "Myrmec", "Nand", "Nas", "Nectophr", "Neof",
            "Nephr", "Numid", "Nycter", "Ochot", "Octop", "Odob", "Odoc", "Okap", "Onisc", "Ophis", "Orc", "Oriol",
            "Ornithorh", "Oryct", "Osteol", "Ostr", "Otar", "Ov", "Pag", "Pagur", "Pan", "Panth", "Pap", "Papilion",
            "Parach", "Paradis", "Paradox", "Paral", "Pass", "Pav", "Pec", "Pelec", "Peloph", "Peram", "Phacoch",
            "Phaeth", "Phal", "Phalanger", "Pharom", "Phas", "Phascol", "Phasmat", "Phoc", "Phoenic", "Phycod", "Phys",
            "Physign", "Pic", "Platan", "Poec", "Pog", "Pomac", "Pong", "Prion", "Prist", "Proc", "Prot", "Protor",
            "Pseud", "Psitt", "Pter", "Pterom", "Pygoc", "Pygosc", "Ramph", "Ran", "Rang", "Raph", "Ratt", "Recurv",
            "Rhinc", "Rhinoc", "Rhinocer", "Rhinod", "Rupic", "Sag", "Saim", "Sarcoph", "Sciur", "Scorp", "Sep", "Serp",
            "Set", "Silurif", "Sim", "Smil", "Spermoph", "Sph", "Sphen", "Sphyr", "Squal", "Stegost", "Strig", "Strix",
            "Struth", "Sul", "Suric", "Sus", "Symph", "Sync", "Tachyg", "Talp", "Tam", "Tap", "Tars", "Tax", "Tetraod",
            "Tetraon", "Teuth", "Threskiorn", "Thyl", "Tragel", "Trem", "Trich", "Trid", "Troch", "Trogl", "Turs", "Tyt",
            "Uroch", "Uropl", "Urs", "Var", "Vesp", "Viv", "Vomb", "Vulp", "Xenop"
        };
        public static readonly string[] nm4 =
        {
            "aatus", "aca", "acal", "achia", "achrus", "acine", "acna", "acus", "ae", "aeidae", "aemus", "aena",
            "aenidae", "aetes", "affa", "ailurus", "aius", "aja", "ajao", "ale", "alis", "alus", "amalis", "ambulus",
            "anchiata", "anger", "aninae", "anta", "anthidae", "antulus", "anus", "aon", "aphinae", "aphus", "apra",
            "aptera", "arctos", "ardus", "arhinus", "ari", "aria", "arodon", "as", "astes", "astos", "ata", "athus",
            "atidae", "atina", "atus", "aurus", "avia", "easter", "ebus", "echus", "ecta", "edeidae", "eidae", "eirodon",
            "ela", "eles", "elis", "ella", "ellidae", "elone", "elphis", "elus", "emus", "entes", "entrus", "enus", "eo",
            "eonidae", "ephalinae", "era", "ercula", "erdo", "eridae", "erix", "erma", "eroptera", "eros", "erra",
            "erta", "erus", "es", "eter", "eus", "eutes", "ia", "ialis", "ianus", "ias", "icetus", "ichthys", "icola",
            "ictis", "ida", "idae", "idea", "ifer", "ifera", "iforme", "igator", "iida", "iidae", "iiformes", "ilia",
            "ilidae", "illa", "illinae", "illus", "ilotis", "ilus", "ina", "inae", "ini", "inia", "inidia", "inoidea",
            "inus", "io", "ioidea", "iones", "ioninae", "iops", "ipedia", "iri", "irostra", "irus", "is", "iscus",
            "istoidea", "ithecus", "ithidae", "ithodes", "ithrix", "itis", "ittacus", "ius", "izon", "lossus", "o",
            "obius", "ocampa", "ocampus", "ocebus", "och", "ochelys", "ochoerus", "odactylus", "odea", "odectus",
            "odidae", "odon", "odontus", "odytes", "oepus", "oerus", "ogale", "oidea", "oileus", "ois", "olagus", "oma",
            "omorpha", "on", "ona", "ong", "ongiae", "onia", "onix", "onta", "ontidae", "ontinae", "onyx", "opex",
            "ophaga", "ophorus", "ophrys", "opidae", "opoda", "oprocta", "ops", "opsis", "optera", "opterus", "opus",
            "or", "ordata", "orhinus", "oria", "ormes", "orus", "oryx", "osaurus", "osteidae", "ostoma", "otamus",
            "otherium", "othrix", "otidae", "otriton", "ouatta", "ounga", "ox", "ozoa", "ua", "uarius", "uinus", "uis",
            "ula", "uma", "ur", "ura", "urga", "uridae", "urnix", "uroidea", "urus", "us", "uta", "uus", "yatis", "ydra",
            "ydridae", "yini", "ylax", "ylus", "ynchus", "yne", "ynnis", "yon", "ypelma", "yphorus", "ypius", "yptes",
            "yptula", "yrna", "ysodon", "ystoma", "yura", "yurus"
        };
        public static readonly string[] nm5 =
        {
            "abel", "acanth", "acul", "acutor", "adel", "aeg", "afr", "agass", "agil", "aj", "al", "alb", "albiv", "alc",
            "alism", "alp", "alt", "amblyrh", "amoyens", "amphib", "anat", "ang", "antip", "ar", "arct", "arg", "as",
            "atr", "aur", "axelr", "bactr", "barb", "bengal", "ber", "bic", "bin", "bint", "bir", "bison", "born",
            "brach", "bub", "buf", "but", "cab", "caff", "camel", "camelop", "cap", "capuc", "car", "carch", "catesb",
            "catt", "centr", "chrys", "cin", "cirr", "civ", "colch", "conc", "corb", "cot", "crist", "croc", "cucull",
            "cunic", "cuv", "cycl", "darw", "delic", "delph", "dem", "derb", "diehl", "ding", "diph", "domest", "dors",
            "dromed", "dug", "electr", "eleg", "eq", "erm", "escul", "europ", "euryc", "falcon", "famil", "fasc",
            "fascic", "fer", "forst", "frag", "franc", "ful", "fulg", "fur", "fusc", "gall", "ganget", "geoffr", "gig",
            "gigant", "glam", "gor", "grauer", "grev", "grunn", "gryp", "guian", "gul", "habropt", "harr", "herc",
            "herm", "hirc", "hoffm", "horr", "humb", "hydroch", "ib", "iguan", "imm", "imper", "ind", "indr", "ir",
            "jacks", "johnst", "jub", "king", "komod", "laev", "lag", "lagotr", "lanig", "larv", "latr", "lemm", "lept",
            "less", "leuc", "liber", "lot", "lum", "lup", "lutr", "lynx", "ma", "macroc", "macul", "magarh", "magell",
            "mal", "man", "mand", "mandt", "mar", "maxill", "maxim", "mel", "melan", "mend", "meph", "mid", "min",
            "monach", "mul", "mur", "muscul", "nas", "natt", "neb", "nghetinh", "niv", "nod", "novaeangl", "obscur",
            "occid", "oedip", "onc", "or", "orc", "orn", "palm", "pan", "pap", "pard", "parv", "pat", "patag", "phys",
            "pic", "pict", "platyrh", "popul", "porc", "prim", "procyon", "punct", "put", "pyger", "pygm", "quagg",
            "radiat", "ratt", "retic", "ridib", "robust", "ros", "rosm", "rubec", "ruf", "rupic", "sap", "scand", "scr",
            "scyph", "serv", "sim", "sond", "sph", "spilog", "splend", "str", "streps", "sulfur", "sum", "sumatr",
            "suric", "susp", "sylv", "taj", "tang", "tar", "taur", "tax", "tempor", "tetr", "tibet", "tigr", "toc",
            "trid", "trogl", "trunc", "typ", "undul", "unic", "ursin", "vin", "vitt", "vitul", "viverr", "volit", "vulg",
            "vulp", "zebr", "zerd", "zyg"
        };
        public static readonly string[] nm6 =
        {
            "acal", "actyla", "acu", "aea", "aena", "aeris", "aeus", "agrus", "aica", "aicus", "aja", "al", "alia",
            "alis", "allus", "alunga", "alus", "ampus", "an", "andus", "ani", "anicus", "ans", "anus", "apra", "ardalis",
            "aria", "arias", "arinia", "aris", "arius", "arum", "arus", "as", "aspis", "aster", "ata", "aticus", "ator",
            "atrae", "atta", "atu", "atum", "atus", "aum", "ayanus", "ea", "eatus", "ectum", "eensis", "eiana", "elia",
            "ellus", "engei", "ens", "ensis", "entalis", "enteus", "entris", "entus", "eo", "ephalus", "er", "era",
            "ereri", "ereus", "eri", "eria", "ersus", "erus", "es", "etta", "etti", "eus", "iacus", "iae", "ianus",
            "iaris", "ias", "iatum", "iatus", "iblis", "ica", "iceps", "iceros", "icha", "iculus", "icus", "idus",
            "iens", "iensis", "ier", "ies", "igenius", "ii", "ilis", "illa", "ilus", "ina", "inea", "inii", "inosa",
            "inum", "inus", "inx", "iol", "iosa", "is", "isci", "iscus", "isii", "itimus", "itis", "ius", "izii", "o",
            "ocome", "odes", "odi", "oditus", "odytes", "oensis", "ofa", "oides", "oldti", "oleuca", "olophus", "olor",
            "on", "onae", "one", "oni", "onicus", "onii", "onyx", "opus", "or", "orius", "ornis", "os", "ostrata",
            "ostris", "osus", "otata", "otis", "oura", "ouxii", "ox", "oyi", "ozoa", "ua", "uco", "ues", "uinus", "ula",
            "ularis", "ulata", "ules", "ulosa", "ulus", "um", "undus", "urnix", "urong", "us", "uta", "uus", "yanus",
            "yi", "ynchos", "ythrus", "yurus"
        };

        // Adjectives
        public static readonly string[] Adjective1 = {
            "Ancient", "Binding", "Blessed", "Blind", "Broken", "Burning", "Condemned", "Conquered", "Cursed", "Damned", "Dark",
            "Demonic", "Distant", "Divine", "Doomed", "Ending", "Endless", "Eternal", "Faded", "Fallen", "Fleeting", "Frozen",
            "Hallowed", "Haunted", "Hellish", "Holy", "Imminent", "Immortal", "Infernal", "Infinite", "Lost", "Ominous", "Relentless",
            "Sacred", "Shattered", "Silent", "Smoldering", "Timeless", "Twisted", "Unholy"
        };
        public static readonly string[] Adjective2 =
        {
            "Ancestors", "Bloodlust", "Comrades", "Damnation", "Dreams", "Fire", "Fires", "Fortune", "Fortunes", "Freedom",
            "Glory", "Hell", "Hells", "Honor", "Hope", "Illusions", "Justice", "Kings", "Lands", "Magic", "Memories", "Might",
            "Misery", "Nightmares", "Nights", "Power", "Powers", "Protection", "Punishment", "Sorrow", "Souls", "Torment", "Trials",
            "Vengeance", "Visions", "Voices", "Warlords", "Wars", "Whispers", "Worlds"
        };
        public static readonly string[] Adjective3 =
        {
            "Ancient", "Arcane", "Atuned", "Bandit's", "Baneful", "Banished", "Barbarian", "Barbaric", "Battleworn",
            "Blood Infused", "Blood-Forged", "Bloodcursed", "Bloodied", "Bloodlord's", "Bloodsurge", "Brutal", "Brutality",
            "Burnished", "Captain's", "Cataclysm", "Cataclysmic", "Challenger", "Challenger's", "Champion", "Champion's",
            "Cold-Forged", "Conqueror", "Conqueror's", "Corrupted", "Crazed", "Crying", "Cursed", "Defender", "Defender's",
            "Defiled", "Demonic", "Desire's", "Desolation", "Destiny's", "Dire", "Doom", "Doom's", "Dragon's", "Dragon", "Ebon",
            "Enchanted", "Engraved", "Eternal", "Exile", "Extinction", "Faith's", "Faithful", "Fearful", "Feral", "Fierce",
            "Fiery", "Fire Infused", "Firesoul", "Forsaken", "Fortune's", "Frenzied", "Frost", "Frozen", "Furious", "Fusion",
            "Ghastly", "Ghost-Forged", "Ghostly", "Gladiator", "Gladiator's", "Grieving", "Guard's", "Guardian's", "Hatred",
            "Haunted", "Heartless", "Hero", "Hero's", "Hollow", "Holy", "Honed", "Honor's", "Hope's", "Hopeless", "Howling",
            "Hungering", "Incarnated", "Infused", "Inherited", "Jade Infused", "Judgement", "Keeper's", "Knightly", "Legionnaire's",
            "Liar's", "Lich", "Lightning", "Lonely", "Loyal", "Lusting", "Malevolent", "Malicious", "Malignant", "Massive", "Mended",
            "Mercenary", "Military", "Misfortune's", "Mourning", "Nightmare", "Oathkeeper's", "Ominous", "Peacekeeper", "Peacekeeper's",
            "Phantom", "Possessed", "Pride's", "Primal", "Prime", "Primitive", "Promised", "Protector's", "Proud", "Recruit's", "Reforged",
            "Reincarnated", "Relentless", "Remorse", "Renewed", "Renovated", "Restored", "Retribution", "Ritual", "Roaring", "Ruby Infused",
            "Rune-Forged", "Savage", "Sentinel", "Shadow", "Silent", "Singing", "Sinister", "Soldier's", "Solitude's", "Sorrow's", "Soul",
            "Soul Infused", "Soul-Forged", "Soulless", "Spectral", "Spite", "Storm", "Storm-Forged", "Stormfury", "Stormguard", "Terror",
            "Thunder", "Thunder-Forged", "Thunderfury", "Thunderguard", "Thundersoul", "Thunderstorm", "Timeworn", "Tormented", "Trainee's",
            "Treachery's", "Twilight", "Twilight's", "Twisted", "Tyrannical", "Undead", "Unholy", "Vanquisher", "Vengeance", "Vengeful",
            "Vicious", "Victor", "Vindication", "Vindicator", "Vindictive", "War-Forged", "Warden's", "Warlord's", "Warped", "Warrior",
            "Warrior's", "Whistling", "Wicked", "Wind's", "Wind-Forged", "Windsong", "Woeful", "Wrathful", "Wretched", "Yearning", "Zealous"
        };
        public static readonly string[] Adjective4 = 
        {
            "Ancient", "Antique", "Apocalypse", "Apocalyptic", "Arcane", "Arched", "Atuned", "Bandit's", "Baneful",
            "Banished", "Barbarian", "Barbaric", "Battleworn", "Blazefury", "Blood Infused", "Blood-Forged", "Bloodcursed",
            "Bloodied", "Bloodlord's", "Bloodsurge", "Bloodvenom", "Bonecarvin", "Brutal", "Brutality", "Burnished", "Cataclysm",
            "Cataclysmic", "Challenger", "Challenger's", "Champion", "Champion's", "Cold-Forged", "Conqueror", "Conqueror's", 
            "Corroded", "Corrupted", "Crazed", "Crying", "Cursed", "Curved", "Dancing", "Dark", "Darkness", "Defender", 
            "Defender's", "Defiled", "Defiling", "Deluded", "Demonic", "Deserted", "Desire's", "Desolation", "Destiny's",
            "Diabolical", "Dire", "Doom", "Doom's", "Dragon's", "Dragonbreath", "Eerie", "Enchanted", "Engraved", "Enlightened",
            "Eternal", "Exiled", "Extinction", "Faith's", "Faithful", "Fancy", "Fearful", "Feral", "Ferocious", "Fierce", 
            "Fiery", "Fire Infused", "Fireguard", "Firesoul", "Firestorm", "Flaming", "Flimsy", "Forsaken", "Fortune's",
            "Foul", "Fragile", "Frail", "Frenzied", "Frost", "Frozen", "Furious", "Fusion", "Ghastly", "Ghost", "Ghost-Forged",
            "Ghostly", "Gladiator", "Gladiator's", "Gleaming", "Glinting", "Greedy", "Grieving", "Grim", "Guard's", "Guardian's",
            "Hailstorm", "Harmonized", "Hateful", "Haunted", "Heartless", "Heinous", "Hero", "Hero's", "Hollow", "Holy", "Honed",
            "Honor's", "Hope's", "Hopeless", "Howling", "Hungering", "Improved", "Impure", "Incarnated", "Infused", "Inherited",
            "Isolated", "Jade Infused", "Judgement", "Keeper's", "Knightly", "Knight's", "Legionnaire's", "Liar's", "Lich",
            "Lightning", "Lonely", "Loyal", "Lustful", "Lusting", "Malevolent", "Malicious", "Malificent", "Malignant", "Massive",
            "Mended", "Mercenary", "Military", "Misfortune's", "Misty", "Moonlit", "Mourning", "Nightmare", "Oathkeeper's",
            "Ominous", "Peacekeeper", "Peacekeeper's", "Phantom", "Polished", "Possessed", "Pride's", "Prideful", "Primal", 
            "Prime", "Primitive", "Promised", "Protector's", "Proud", "Pure", "Putrid", "Raging", "Recruit's", "Refined",
            "Reforged", "Reincarnated", "Relentless", "Remorseful", "Renewed", "Renovated", "Replica", "Restored", "Retribution",
            "Ritual", "Roaring", "Ruby Infused", "Rune-Forged", "Runed", "Rusty", "Savage", "Sentinel", "Shadow", "Shamanic",
            "Sharpened", "Silent", "Singed", "Singing", "Sinister", "Skyfall", "Smooth", "Soldier's", "Solitude's", "Sorcerer's",
            "Sorrow's", "Soul", "Soul Infused", "Soul-Forged", "Soulcursed", "Soulless", "Spectral", "Spectral-Forged", "Spiteful",
            "Storm", "Storm-Forged", "Stormfury", "Stormguard", "Terror", "Thirsting", "Thirsty", "Thunder", "Thunder-Forged",
            "Thunderfury", "Thunderguard", "Thundersoul", "Thunderstorm", "Timeworn", "Tormented", "Trainee's", "Treachery's", 
            "Twilight", "Twilight's", "Twisted", "Tyrannical", "Undead", "Unholy", "Vanquisher", "Vengeance", "Vengeful", 
            "Venom", "Vicious", "Victor", "Vile", "Vindication", "Vindicator", "Vindictive", "Void", "Volcanic", "Vowed", 
            "War", "War-Forged", "Warden's", "Warlord's", "Warp", "Warped", "Warrior", "Warrior's", "Whistling", "Wicked",
            "Wind's", "Wind-Forged", "Windsong", "Woeful", "Wrathful", "Wretched", "Yearning", "Zealous"
        };

        public static readonly string[] AdjectiveVerbPreposition =
        {
            "Armament", "Scales", "Guard", "Bastion", "Steel", "Defense", "Bane", "Bond", "Boon", "Call", "Champion",
            "Conqueror", "Crusader", "Cry", "Curator", "Dawn", "Fall", "End", "Demise", "Birth", "Death", "Edge", "Blight",
            "Burden", "Blessing", "Fortune", "Defender", "Defiler", "Deflector", "Destroyer", "Emissary", "Ender", "Favor",
            "Foe", "Gift", "Glory", "Guard", "Guardian", "Heirloom", "Hero", "Hope", "Incarnation", "Keeper", "Last Hope",
            "Last Stand", "Legacy", "Memory", "Might", "Oath", "Pact", "Pledge", "Promise", "Protection", "Protector", "Reach",
            "Shepherd", "Soul", "Steward", "Terror", "Token", "Tribute", "Vengeance", "Vindicator", "Visage", "Voice", "Ward",
            "Warden", "Whisper", "Wit", "Vest", "Chestguard", "Armor", "Tunic", "Breastplate", "Chestplate", "Batteplate",
            "Chestpiece", "Cuirass", "Greatplate"
        };

        // Materials
        public static readonly string[] MaterialHeavy =
        {
            "Cloth", "Heavy Hide", "Heavy Leather", "Hide", "Leather", "Linen", "Padded", "Quilted", "Rugged Leather",
            "Scaled", "Silk", "Wool", "Embroided"
        };
        public static readonly string[] MaterialLight =
        {
            "Adamantite", "Scaled", "Bone", "Bronze", "Bronzed", "Ivory", "Ebon", "Golden", "Iron", "Mithril", "Obsidian",
            "Silver", "Skeletal", "Steel", "Mail", "Chain", "Chainmail", "Titanium", "Demon"
        };
        public static readonly string[] WeaponMaterial =
        {
            "Adamantite", "Bone", "Bronze", "Bronzed", "Ivory", "Ebon", "Glass", "Golden", "Iron",
            "Ironbark", "Mithril", "Obsidian", "Silver", "Skeletal", "Steel", "Titanium", "Onyx",
            "Ivory", "Ironbark", "Oak", "Maple", "Yew", "Ashwood", "Warpwood", "Ebonsteel", "Shadowsteel"
        };

        // Nouns
        public static readonly string[] Noun =
        {
            "Absorption", "the Phoenix", "Adventure", "Agony", "Ancient Power", "Ancient Powers", "Anger", "Anguish",
            "Annihilation", "Arcane Magic", "Arcane Power", "Arcane Resist", "Archery", "Ashes", "Assassination", "Assassins",
            "Assaults", "Auras", "Awareness", "Barriers", "Beginnings", "Binding", "Black Magic", "Blast Protection",
            "Blessed Fortune", "Blessed Fortunes", "Blessings", "Blight", "Blood", "Bloodlust", "Bloodshed", "Bravery",
            "Broken Bones", "Broken Dreams", "Broken Families", "Broken Worlds", "Burdens", "Carnage", "Cataclysms", "Chaos",
            "Clarity", "Conquered Worlds", "Corruption", "Courage", "Creation", "Cunning", "Danger", "Dark Magic", "Dark Powers",
            "Dark Souls", "Darkness", "Dawn", "Decay", "Deception", "Defiance", "Deflection", "Delirium", "Delusions", "Demon Fire",
            "Demons", "Denial", "Desecration", "Despair", "Destruction", "Devotion", "Diligence", "Discipline", "Dishonor", "Dismay",
            "Dominance", "Domination", "Doom", "Dragons", "Dragonsouls", "Dread", "Dreams", "Due Diligence", "Duels", "Dusk",
            "Echoes", "Enchantments", "Ended Dreams", "Ending Hope", "Ending Misery", "Ends", "Eternal Bloodlust", "Eternal Damnation",
            "Eternal Glory", "Eternal Justice", "Eternal Rest", "Eternal Sorrow", "Eternal Struggles", "Eternity", "Executions",
            "Extinction", "Faded Memories", "Fallen Kings", "Fallen Souls", "Fire", "Fire Magic", "Fire Power", "Fire Protection",
            "Fire Resist", "Fools", "Forging", "Fortitude", "Fortune", "Frost", "Frost Power", "Frost Resist", "Frozen Hells",
            "Fury", "Ghosts", "Giants", "Giantslaying", "Glory", "Grace", "Greed", "Grieving Widows", "Guardians", "Hate",
            "Hatred", "Healing", "Hell", "Hell's Games", "Hellfire", "Hellish Torment", "Heroes", "Holy Might", "Honor",
            "Hope", "Horrors", "Ice", "Ice Magic", "Illusions", "Immortality", "Inception", "Infinite Trials", "Infinity",
            "Insanity", "Justice", "Kings", "Life", "Lifemending", "Lifestealing", "Light's Hope", "Limbo", "Lost Comrades",
            "Lost Hope", "Lost Souls", "Lost Voices", "Lost Worlds", "Mercy", "Might", "Miracles", "Misery", "Mists", "Moonlight",
            "Mysteries", "Mystery", "Nature", "Necromancy", "Nightmares", "Oblivion", "Paradise", "Patience", "Phantoms", "Power",
            "Prayers", "Pride", "Pride's Fall", "Prophecies", "Protection", "Putrefaction", "Reckoning", "Recoil", "Redemption",
            "Regret", "Regrets", "Resilience", "Respect", "Riddles", "Ruins", "Runes", "Salvation", "Secrecy", "Secrets", "Serenity",
            "Shadows", "Shifting Sands", "Silence", "Slaughter", "Slaying", "Smite", "Solitude", "Souls", "Stealth", "Stone", "Storms",
            "Strength", "Subtlety", "Suffering", "Suffering's End", "Sunfire", "Sunlight", "Swordbreaking", "Tears", "Terror",
            "Terrors", "Thieves", "Thorns", "Thunder", "Thunders", "Titans", "Torment", "Traitors", "Trust", "Truth", "Truths",
            "Twilight", "Twilight's End", "Twisted Visions", "Undoing", "Unholy Blight", "Unholy Might", "Valiance", "Valor",
            "Vengeance", "Vigor", "Visions", "War", "Whispers", "Wisdom", "Woe", "Wonders", "Wraiths", "Zeal", "the Ancients",
            "the Archer", "the Banished", "the Basilisk", "the Bear", "the Beast", "the Berserker", "the Blessed", "the Boar",
            "the Breaking Storm", "the Brotherhood", "the Burning Sun", "the Caged Mind", "the Cataclysm", "the Champion", "the Claw",
            "the Corrupted", "the Covenant", "the Crown", "the Crusader", "the Damned", "the Day", "the Daywalker", "the Dead",
            "the Depth", "the Depths", "the Dragons", "the Dreadlord", "the Eagle", "the Earth", "the East", "the Eclipse", "the Emperor",
            "the End", "the Enigma", "the Fallen", "the Falling Sky", "the Flames", "the Forest", "the Forests", "the Forgotten",
            "the Forsaken", "the Gargoyle", "the Gladiator", "the Gods", "the Harvest", "the Hunter", "the Immortal", "the Immortals",
            "the Incoming Storm", "the Insane", "the Isles", "the King", "the Knight", "the Lasting Night", "the Leviathan", "the Light",
            "the Lion", "the Lionheart", "the Lone Victor", "the Lone Wolf", "the Lost", "the Mage", "the Moon", "the Moonwalker",
            "the Mountain", "the Mountains", "the Night", "the Night Sky", "the Nightstalker", "the North", "the Occult", "the Oracle",
            "the Phoenix", "the Plague", "the Prince", "the Princess", "the Prisoner", "the Prodigy", "the Prophecy", "the Prophet",
            "the Protector", "the Queen", "the Scourge", "the Seer", "the Serpent", "the Setting Sun", "the Shadows", "the Sky",
            "the South", "the Stars", "the Steward", "the Storm", "the Summoner", "the Sun", "the Sunwalker", "the Swamp", "the Talon",
            "the Titans", "the Undying", "the Victor", "the Void", "the Volcano", "the Ward", "the Warrior", "the West", "the Whale",
            "the Whispers", "the Wicked", "the Wind", "the Wolf", "the World", "the Wretched"
        };
        public static readonly string[] WeaponNoun = 
        {
            "of Agony", "of Ancient Power", "of Anguish", "of Ashes", "of Assassins", "of Black Magic", 
            "of Blessed Fortune", "of Blessings", "of Blight", "of Blood", "of Bloodlust", "of Broken Bones", 
            "of Broken Dreams", "of Broken Families", "of Burdens", "of Chaos", "of Closing Eyes", "of Conquered Worlds",
            "of Corruption", "of Cruelty", "of Cunning", "of Dark Magic", "of Dark Souls", "of Darkness", "of Decay", 
            "of Deception", "of Degradation", "of Delusions", "of Denial", "of Desecration", "of Diligence", "of Dismay",
            "of Dragonsouls", "of Due Diligence", "of Echoes", "of Ended Dreams", "of Ending Hope", "of Ending Misery", 
            "of Eternal Bloodlust", "of Eternal Damnation", "of Eternal Glory", "of Eternal Justice", "of Eternal Rest",
            "of Eternal Sorrow", "of Eternal Struggles", "of Eternity", "of Executions", "of Faded Memories", 
            "of Fallen Souls", "of Fools", "of Frost", "of Frozen Hells", "of Fury", "of Giants", "of Giantslaying",
            "of Grace", "of Grieving Widows", "of Hate", "of Hatred", "of Hell's Games", "of Hellish Torment",
            "of Heroes", "of Holy Might", "of Honor", "of Hope", "of Horrid Dreams", "of Horrors", "of Illuminated Dreams",
            "of Illumination", "of Immortality", "of Inception", "of Infinite Trials", "of Insanity", "of Invocation",
            "of Justice", "of Light's Hope", "of Lost Comrades", "of Lost Hope", "of Lost Voices", "of Lost Worlds", 
            "of Magic", "of Mercy", "of Misery", "of Mountains", "of Mourning", "of Mystery", "of Necromancy", "of Nightmares", 
            "of Oblivion", "of Perdition", "of Phantoms", "of Power", "of Pride", "of Pride's Fall", "of Putrefaction",
            "of Reckoning", "of Redemption", "of Regret", "of Riddles", "of Secrecy", "of Secrets", "of Shadow Strikes", 
            "of Shadows", "of Shifting Sands", "of Shifting Worlds", "of Silence", "of Slaughter", "of Souls", "of Stealth",
            "of Storms", "of Subtlety", "of Suffering", "of Suffering's End", "of Summoning", "of Terror", "of Thunder", 
            "of Time-Lost Memories", "of Timeless Battles", "of Titans", "of Torment", "of Traitors", "of Trembling Hands",
            "of Trials", "of Truth", "of Twilight's End", "of Twisted Visions", "of Unholy Blight", "of Unholy Might", "of Vengeance", 
            "of Visions", "of Wasted Time", "of Widows", "of Wizardry", "of Woe", "of Wraiths", "of Zeal", "of the Ancients", 
            "of the Banished", "of the Basilisk", "of the Beast", "of the Blessed", "of the Breaking Storm", "of the Brotherhood", 
            "of the Burning Sun", "of the Caged Mind", "of the Cataclysm", "of the Champion", "of the Claw", "of the Corrupted",
            "of the Covenant", "of the Crown", "of the Damned", "of the Daywalker", "of the Dead", "of the Depth", "of the Dreadlord",
            "of the Earth", "of the East", "of the Emperor", "of the Empty Void", "of the End", "of the Enigma", "of the Fallen", 
            "of the Falling Sky", "of the Flame", "of the Forest", "of the Forgotten", "of the Forsaken", "of the Gladiator",
            "of the Harvest", "of the Immortal", "of the Incoming Storm", "of the Insane", "of the King", "of the Lasting Night",
            "of the Leviathan", "of the Light", "of the Lion", "of the Lionheart", "of the Lone Victor", "of the Lone Wolf",
            "of the Lost", "of the Moon", "of the Moonwalker", "of the Night Sky", "of the Night", "of the Nightstalker", 
            "of the North", "of the Occult", "of the Oracle", "of the Phoenix", "of the Plague", "of the Prince", "of the Protector",
            "of the Queen", "of the Serpent", "of the Setting Sun", "of the Shadows", "of the Sky", "of the South", "of the Stars",
            "of the Storm", "of the Summoner", "of the Sun", "of the Sunwalker", "of the Talon", "of the Undying", "of the Victor",
            "of the Void", "of the West", "of the Whispers", "of the Wicked", "of the Wind", "of the Wolf", "of the World", "of the Wretched"
        };

        // Dictionary for random Helmet names
        public static readonly string[] HelmetHeavy =
        {
            "Bandana", "Cap", "Coif", "Cowl", "Facemask", "Headguard", "Headpiece", "Helm", "Hood", "Mask"
        };
        public static readonly string[] HelmetLight =
        {
            "Casque", "Crown", "Faceguard", "Gaze", "Greathelm", "Headcover", "Headguard", "Helm", "Helmet", "Jaws", "Visage"
        };

        // Dictionary for random Chest names
        public static readonly string[] ChestHeavy =
        {
            "Breastplate", "Tunic", "Wraps", "Vest", "Vestment", "Robes", "Chestguard", "Jerkin", "Raiment", "Garments"
        };
        public static readonly string[] ChestLight =
        {
            "Vest", "Chestguard", "Armor", "Tunic", "Breastplate", "Chestplate", "Batteplate", "Chestpiece", "Cuirass", "Greatplate"
        };

        // Dictionary for random Leggins names
        public static readonly string[] LegginsHeavy = 
        {
            "Legwraps", "Legguards", "Kilt", "Skirt", "Pants", "Robes", "Breeches", "Leggings", "Britches"
        };
        public static readonly string[] LegginsLight = 
        {
            "Legguards", "Platelegs", "Legplates", "Greaves", "Skirt", "Leggings", "Kilt"
        };

        // Dictionary for random Boots names
        public static readonly string[] BootsHeavy = 
        {
            "Sprinters", "Sandals", "Boots", "Heels", "Treads", "Feet", "Footguards", "Footpads", "Walkers", "Footsteps"
        };
        public static readonly string[] BootsLight = 
        {
            "Boots", "Greaves", "Stompers", "Greatboots", "Treads", "Spurs", "Warboots", "Sabatons", "Feet", "Walkers", "Footguards"
        };

        // Dictionary for random Weapon names
        public static readonly string[] WeaponName =
        {
            "Shadowfang", "Azurewrath", "Assurance", "ForgetMeNot", "Red Obsidian", "Abyssal Shard", "Aetherius",
            "Agatha", "Alpha", "Amnesia", "Anduril", "Anger's Tear", "Apocalypse", "Armageddon", "Arondite", "Ashrune",
            "Betrayal", "Betrayer", "Blackest Heart", "Blackout", "Blade of a Thousand Cuts", "Blade of the Grave",
            "Blazefury", "Blazeguard", "Blight's Plight", "Blind Justice", "Blinkstrike", "Bloodquench", "Bloodweep",
            "Broken Promise", "Brutality", "Cataclysm", "Catastrophe", "Celeste", "Chaos", "Cometfell", "Convergence",
            "Corruption", "Darkheart", "Darkness", "Dawn", "Dawn of Ruins", "Dawnbreaker", "Deathbringer", "Deathraze", 
            "Decimation", "Desolation", "Despair", "Destiny's Song", "Devine", "Devourer", "Dirge", "Divine Light",
            "Doomblade", "Doombringer", "Draughtbane", "Due Diligence", "Early Retirement", "Echo", "Piece Maker",
            "Eclipse", "Endbringer", "Epilogue", "Espada", "Eternal Harmony", "Eternal Rest", "Extinction", "Faithkeeper",
            "Fallen Champion", "Fate", "Final Achievement", "Fleshrender", "Florance", "Frenzy", "Fury", "Ghost Reaver", 
            "Ghostwalker", "Gladius", "Glimmer", "Godslayer", "Grasscutter", "Grieving Blade", "Gutrender", "Hatred's Bite",
            "Heartseeker", "Heartstriker", "Hell's Scream", "Hellfire", "Hellreaver", "Hollow Silence", "Honor's Call",
            "Hope's End", "Infamy", "Interrogator", "Justice", "Justifier", "King's Defender", "King's Legacy", "Kinslayer",
            "Klinge", "Knight's Fall", "Knightfall", "Lament", "Last Rites", "Last Words", "Lazarus", "Life's Limit", "Lifedrinker",
            "Light's Bane", "Lightbane", "Lightbringer", "Lightning", "Limbo", "Loyalty", "Malice", "Mangler", "Massacre", "Mercy",
            "Misery's End", "Morbid Doom", "Morbid Will", "Mournblade", "Narcoleptic", "Needle", "Nethersbane", "Night's Edge",
            "Night's Fall", "Nightbane", "Nightcrackle", "Nightfall", "Nirvana", "Oathbreaker", "Oathkeeper", "Oblivion", "Omega",
            "Orenmir", "Peacekeeper", "Perfect Storm", "Persuasion", "Prick", "Purifier", "Rage", "Ragespike", "Ragnarok", "Reaper",
            "Reaper's Toll", "Reckoning", "Reign of Misery", "Remorse", "Requiem", "Requiem of the Lost", "Retirement",
            "Righteous Might", "Rigormortis", "Savagery", "Scalpel", "Scar", "Seethe", "Severance", "Shadow Strike", "Shadowsteel",
            "Silence", "Silencer", "Silver Saber", "Silverlight", "Skullcrusher", "Slice of Life", "Soul Reaper", "Soulblade",
            "Soulrapier", "Spada", "Spike", "Spineripper", "Spiteblade", "Stalker", "Starshatterer", "Sting", "Stinger", "Storm",
            "Storm Breaker", "Stormbringer", "Stormcaller", "Storm-Weaver", "Striker", "Sun Strike", "Suspension", "Swan Song",
            "The Ambassador", "The Black Blade", "The End", "The Facelifter", "The Light", "The Oculus", "The Stake", "The Untamed",
            "The Unyielding", "The Void", "Thorn", "Thunder", "Toothpick", "Tranquility", "Treachery", "Trinity", "Tyrhung", 
            "Unending Tyranny", "Unholy Might", "Valkyrie", "Vanquisher", "Vengeance", "Venom", "Venomshank", "Warmonger",
            "Widow Maker", "Willbreaker", "Winterthorn", "Wit's End", "Witherbrand", "Wolf", "Worldbreaker", "Worldslayer"
        };
        public static readonly string[] WeaponName2 =
        {
            "Annihilation", "Betrayer", "Blade", "Blessed Blade", "Blood Blade", "Bond", "Boon",
            "Breaker", "Bringer", "Broadsword", "Butcher", "Call", "Carver", "Champion", "Claymore",
            "Conqueror", "Crusader", "Cry", "Cunning", "Dark Blade", "Dawn", "Defender", "Defiler",
            "Deflector", "Destroyer", "Doomblade", "Edge", "Ender", "Etcher", "Executioner", "Favor",
            "Ferocity", "Foe", "Gift", "Glory", "Greatsword", "Guardian", "Heirloom", "Hope", "Incarnation",
            "Jaws", "Katana", "Last Hope", "Last Stand", "Legacy", "Longblade", "Longsword", "Mageblade",
            "Memory", "Might", "Oath", "Pact", "Pledge", "Promise", "Protector", "Quickblade", "Rapier",
            "Ravager", "Razor", "Reach", "Reaper", "Reaver", "Runed Blade", "Saber", "Sabre", "Savagery",
            "Scimitar", "Sculptor", "Secret", "Shortsword", "Skewer", "Slayer", "Slicer", "Soul", "Spellblade",
            "Spine", "Swiftblade", "Sword", "Terror", "Token", "Tribute", "Vengeance", "Voice", "Warblade",
            "Warglaive", "Whisper", "Wit"
        };

        // Dictionary for random Sword names
        public static readonly string[] SwordNames = 
        {
            "Blade", "Broadsword", "Claymore", "Defender", "Deflector", "Doomblade", "Greatsword", 
            "Guardian", "Katana", "Longsword", "Mageblade", "Protector", "Quickblade", "Rapier",
            "Reaver", "Sabre", "Scimitar", "Shortsword", "Slicer", "Spellblade", "Swiftblade", "Sword",
            "Warblade", "Skewer", "Carver", "Etcher", "Sculptor", "Razor", "Crusader"
        };

        // Dictionary for random Hummer names
        public static readonly string[] HummerNames = 
        {
            "Mace", "Bludgeon", "Maul", "Hammer", "Mallet", "Crusher", "Battlehammer",
            "Greathammer", "Smasher", "Warmace", "Hammer", "Mace", "Scepter", "Pummeler"
        };

        // Dictionary for random Axe names
        public static readonly string[] AxeNames = 
        {
            "Battle Axe", "Chopper", "Axe", "Edge", "Crescent", "Cleaver", "Greataxe", 
            "Dualblade", "Broadaxe", "Reaver", "War Axe", "Ravager", "Maul"
        };

        // Dictionary for random Spear names
        public static readonly string[] SpearNames = 
        {
            "Spear", "Trident", "Halberd", "Polearm", "Pike", "Spike", "Ranseur", "Javelin",
            "Lance", "Piercer", "Harpoon", "Prick", "Pricker", "Impaler", "Skewer", "Skiver"
        };
    }
}

