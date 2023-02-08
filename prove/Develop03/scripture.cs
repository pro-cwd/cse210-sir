public class Scripture
{   
    private string[] jhonOne = {
        "In the bbeginning was the Word, and the cWord was with God, and the dWord was eGod.",
        "The same was in the abeginning with God.",
        "All things were amade by him; and without him was not any thing made that was made.",
        "In him was alife; and the life was the blight of men.",
        "And the alight shineth in bdarkness; and the darkness ccomprehended it not.",
        "There was a man sent from God, whose name was aJohn.",
        "The same came for a awitness, to bear bwitness of the Light, that all men through him might cbelieve.",
        "He was not that Light, but was sent to bear witness of that Light.",
        "That was the true aLight, which blighteth cevery man that cometh into the world.",
        "He was in the aworld, and the bworld was cmade by him, and the world dknew him not.",
        "He came unto his own, and his own areceived him not.",
        "But as many as areceived him, to them gave he bpower to become the csons of God, even to them that believe on his dname:",
        "Which were aborn, not of blood, nor of the will of the flesh, nor of the will of man, but of God.",
        "And the Word was made aflesh, and bdwelt among us, (and we cbeheld his dglory, the glory as of the eonly fbegotten of the Father,) full of ggrace and truth.",
        "John bare awitness of him, and cried, saying, This was he of whom I spake, He that cometh after me is preferred before me: for he was before me.",
        "And of his afulness have all we received, and bgrace for grace.",
        "For the blaw was given by Moses, but cgrace and dtruth came by Jesus Christ.",
        "No aman hath bseen God cat any time; the only begotten Son, which is in the bosom of the Father, he hath ddeclared him.",
        "And this is the record of aJohn, when the Jews sent priests and Levites from Jerusalem to ask him, Who art thou?",
        "And he confessed, and denied not; but confessed, I am not the Christ.",
        "And they asked him, What then? Art thou aElias? And he saith, I am not. Art thou that prophet? And he answered, No.",
        "Then said they unto him, Who art thou? that we may give an answer to them that sent us. What sayest thou of thyself?",
        "He said, I am the avoice of one crying in the wilderness, Make bstraight the cway of the Lord, as said the prophet Esaias.",
        "And they which were sent were of the Pharisees.",
        "And they asked him, and said unto him, Why baptizest thou then, if thou be not that Christ, nor Elias, neither that prophet?",
        "John answered them, saying, I baptize with awater: but there standeth one among you, whom ye know not;",
        "He it is, who coming after me is preferred before me, whose bshoe’s latchet I am not worthy to unloose.",
        "These things were done in aBethabara beyond Jordan, where John was baptizing.",
        "The next day John seeth Jesus coming unto him, and saith, Behold the aLamb of God, which taketh away the bsin of the world.",
        "This is he of whom I said, After me cometh a man which is preferred before me: for he was before me.",
        "And I knew him not: but that he should be made manifest to Israel, therefore am I come baptizing with water.",
        "And John abare record, saying, I saw the bSpirit descending from heaven like a cdove, and it abode upon him.",
        "And I knew him not: but he that sent me to baptize with water, the same said unto me, Upon whom thou shalt see the Spirit descending, and remaining on him, the same is he which baptizeth with the bHoly Ghost.",
        "And I saw, and bare arecord that this is the Son of God.",
        "Again the next day after John stood, and two of his disciples;",
        "And looking upon Jesus as he walked, he saith, Behold the aLamb of God!",
        "And the two disciples heard him speak, and they followed Jesus.",
        "Then Jesus turned, and saw them following, and saith unto them, What seek ye? They said unto him, Rabbi, (which is to say, being interpreted, Master,) where dwellest thou?",
        "He saith unto them, Come and see. They came and saw where he dwelt, and abode with him that day: for it was about the tenth hour.",
        "One of the two which heard John speak, and afollowed him, was Andrew, Simon Peter’s brother.",
        "He first findeth his own brother Simon, and saith unto him, We have found the aMessias, which is, being interpreted, the Christ.",
        "And he brought him to Jesus. And when Jesus beheld him, he said, Thou art Simon the son of Jona: thou shalt be called aCephas, which is by interpretation, A stone.",
        "The day following Jesus would go forth into Galilee, and findeth Philip, and saith unto him, Follow me.",
        "Now Philip was of Bethsaida, the city of Andrew and Peter.",
        "Philip findeth Nathanael, and saith unto him, We have found him, of whom aMoses in the law, and the prophets, did bwrite, Jesus of Nazareth, the son of Joseph.",
        "And Nathanael said unto him, Can there any good thing come out of Nazareth? Philip saith unto him, Come and see.",
        "Jesus saw aNathanael coming to him, and saith of him, Behold an Israelite indeed, in whom is no bguile!",
        "Nathanael saith unto him, Whence knowest thou me? Jesus answered and said unto him, Before that Philip called thee, when thou wast under the fig tree, I saw thee.",
        "Nathanael answered and saith unto him, Rabbi, thou art the aSon of God; thou art the bKing of Israel.",
        "Jesus answered and said unto him, Because I said unto thee, I saw thee under the fig tree, believest thou? thou shalt see greater things than these.",
        "And he saith unto him, Verily, verily, I say unto you, Hereafter ye shall see heaven open, and the angels of God ascending and descending upon the Son of man."
        };

    Reference chap = new Reference();
    private string _chapter = chap.References();
    private string _book = chap._num;
    string j = "John";
    string g = "Galatians";
    string ja = "James";

    public void Verses()
    {
        if (_book == j && _chapter == 1)
        {
            foreach (int i in jhonOne.Length)
            {
                Console.WriteLine(i);
            }
            Console.Write("Please choose a verse:");
            string vrs = Console.ReadLine();
            int verse = int.Parse(vrs);
        }
    }

}