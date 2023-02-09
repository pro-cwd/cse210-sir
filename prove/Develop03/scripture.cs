public class Scripture
{   
    public string[] _johnOne = {
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

   
    public int _verse;
    public int _verse2;
    string[] versesPrint = new string[5];
    
    public Scripture()
    {
    }

    public void John1()
    {
        for (int indice = 0; indice < _johnOne.Length; indice++)
        {
            int i = indice + 1;
            string elemento = _johnOne[indice];
            Console.Write(i);
            // Console.Write(elemento);
            //Imprimir también una coma
            if (i != _johnOne.Length)
            {
                Console.Write(", ");
            } else
            {
                Console.Write(".");
            };
            if (i == _verse)
            {
                versesPrint.Append(elemento);
            };
        };
    }

    public string[] _johnTwo = {
        "And the athird day there was a marriage in Cana of Galilee; and the mother of Jesus was there:",
        "And both Jesus was called, and his disciples, to the marriage.",
        "And when they wanted wine, the mother of Jesus saith unto him, They have no wine.",
        "Jesus saith unto her, aWoman, what have I to do with thee? mine hour is not yet come.",
        "His mother saith unto the servants, Whatsoever he saith unto you, do it.",
        "And there were set there six waterpots of stone, after the manner of the apurifying of the Jews, containing two or three firkins apiece.",
        "Jesus saith unto them, Fill the waterpots with water. And they filled them up to the brim.",
        "And he saith unto them, Draw out now, and bear unto the governor of the feast. And they bare it.",
        "When the ruler of the feast had tasted the water that was made wine, and knew not whence it was: (but the servants which drew the water knew;) the governor of the feast called the bridegroom,",
        "And saith unto him, Every man at the beginning doth set forth good wine; and when men have well drunk, then that which is worse: but thou hast kept the good wine until now.",
        "This abeginning of bmiracles did Jesus in Cana of Galilee, and manifested forth his glory; and his disciples believed on him.",
        "After this he went down to Capernaum, he, and his mother, and his abrethren, and his disciples: and they continued there not many days.",
        "And the Jews’ passover was at hand, and Jesus went up to Jerusalem,",
        "And found in the temple those that sold oxen and sheep and doves, and the changers of amoney sitting:",
        "And when he had made a ascourge of small cords, he drove them all out of the temple, and the sheep, and the oxen; and poured out the changers’ money, and overthrew the tables;",
        "And said unto them that sold doves, Take these things hence; make not my Father’s house an house of merchandise.",
        "And his disciples remembered that it was written, The azeal of thine house hath beaten me up.",
        "Then answered the Jews and said unto him, What asign shewest thou unto us, seeing that thou doest these things?",
        "Jesus answered and said unto them, Destroy this atemple, and in three days I will braise it up.",
        "Then said the Jews, Forty and six years was this atemple in building, and wilt thou rear it up in three days?",
        "But he spake of the temple of his body.",
        "When therefore he was risen from the dead, his disciples remembered that he had said this unto them; and they believed the scripture, and the word which Jesus had said.",
        "Now when he was in Jerusalem at the apassover, in the feast day, many believed in his bname, when they saw the cmiracles which he did.",
        "But Jesus did not acommit himself unto them, because he bknew all cmen,",
        "And needed not that any should testify of man: for he aknew what was in bman."
    };

    public void John2()
    {
    for (int indice = 0; indice < _johnTwo.Length; indice++)
        {
            int i = indice + 1;
            string elemento = _johnTwo[indice];
            Console.Write(i);
            // Console.Write(elemento);
            //Imprimir también una coma
            if (i != _johnTwo.Length)
            {
            Console.Write(", ");
            } else
            {
            Console.Write(".");
            };
        };
    }
    public string[] _johnThree = {
        "There was a man of the Pharisees, named aNicodemus, a bruler of the Jews:",
        "The same came to Jesus by night, and said unto him, Rabbi, we know that thou art a teacher come from God: for no man can do these amiracles that thou doest, except bGod be with him.",
        "Jesus answered and said unto him, Verily, verily, I say unto thee, Except a man be aborn bagain, he cannot csee the kingdom of God.",
        "Nicodemus saith unto him, How can a man be born when he is old? can he enter the second time into his mother’s womb, and be born?",
        "Jesus answered, Verily, verily, I say unto thee, Except a man be aborn of bwater and of the cSpirit, he cannot denter into the kingdom of God.",
        "That which is born of the flesh is flesh; and that which is born of the Spirit is spirit.",
        "Marvel not that I said unto thee, Ye must be aborn again.",
        "The awind bloweth where it listeth, and thou hearest the sound thereof, but canst not tell whence it cometh, and whither it goeth: so is every one that is born of the bSpirit.",
        "Nicodemus answered and said unto him, How can these things be?",
        "Jesus answered and said unto him, Art thou a master of Israel, and knowest not these things?",
        "aVerily, verily, I say unto thee, We speak that we do know, and btestify that we have seen; and ye receive not our witness.",
        "If I have told you earthly things, and ye abelieve not, how shall ye believe, if I tell you of heavenly things?",
        "And no man hath aascended up to heaven, but he that bcame down from heaven, even the cSon of man which is in heaven.",
        "And as Moses lifted up the aserpent in the wilderness, even so must the bSon of man be lifted up:",
        "That whosoever believeth in him should not perish, but have eternal life.",
        "For aGod so bloved the cworld, that he dgave his eonly begotten fSon, that whosoever gbelieveth in him should not perish, but have heverlasting ilife.",
        "For God asent not his Son into the world to bcondemn the world; but that the world through him might be csaved.",
        "He that believeth on him is not condemned: but he that abelieveth not is condemned already, because he hath not believed in the bname of the only begotten cSon of God.",
        "And this is the condemnation, that alight is come into the world, and men loved bdarkness rather than light, because their cdeeds were evil.",
        "For every one that doeth aevil bhateth the light, neither cometh to the light, lest his deeds should be reproved.",
        "But he that adoeth btruth cometh to the clight, that his deeds may be made manifest, that they are wrought in God.",
        "After these things came Jesus and his disciples into the land of Judæa; and there he tarried with them, and abaptized.",
        "And John also was baptizing in Ænon near to Salim, because there was much awater there: and they came, and were bbaptized.",
        "For John was not yet cast into prison.",
        "Then there arose a question between some of John’s disciples and the Jews about purifying.",
        "And they came unto John, and said unto him, Rabbi, he that was with thee beyond Jordan, to whom thou barest witness, behold, the same baptizeth, aand all men come to him.",
        "John answered and said, A man can areceive nothing, except it be given him from heaven.",
        "Ye yourselves bear me witness, that I said, I am not the Christ, but that I am sent before him.",
        "He that hath the bride is the bridegroom: but the friend of the bridegroom, which standeth and heareth him, rejoiceth greatly because of the bridegroom’s voice: this my joy therefore is fulfilled.",
        "He must increase, but I must decrease.",
        "He that cometh from aabove is above all: he that is of the earth is earthly, and speaketh of the earth: he that cometh from heaven is above all.",
        "And what he hath seen and heard, that he atestifieth; and no man receiveth his testimony.",
        "He that hath received his testimony hath aset to his bseal that God is true.",
        "For he whom God hath sent aspeaketh the words of God: bfor God giveth not the Spirit by measure unto him.",
        "The Father loveth the aSon, and hath bgiven all cthings into his hand.",
        "He that believeth on the Son hath beverlasting life: and he that cbelieveth not the Son shall not see life; but the dwrath of God abideth on him."
    };

    public void John3()
    {
    for (int indice = 0; indice < _johnThree.Length; indice++)
        {
            int i = indice + 1;
            string elemento = _johnThree[indice];
            Console.Write(i);
            // Console.Write(elemento);
            //Imprimir también una coma
            if (i != _johnThree.Length)
            {
            Console.Write(", ");
            } else
            {
            Console.Write(".");
            };
            
        };
    }

    static int searchIndex(int[] array, int search)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == search)
                {
                    return i;
                }
            }
            return -1;
        }
}