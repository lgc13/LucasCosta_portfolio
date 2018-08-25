#include <string>

using namespace std;

/***********************************************************/
/*                CLASS BOX                         */
/* has the constructor and all defintions                  */
/* also shows all the prototypes          */
/***********************************************************/
class Box
{
  public:
    Box(int, char, char);    //this is the constructor definition
    Box(int);

    //PROTOTYPES
    int GetSize();
    int Perimeter();
    int Area();
    void Grow();
    void Shrink();
    void SetBorder(char);
    void SetFill(char);
    void Draw();
    void Summary();

  private:
    int _size;
    char _BorderCharacter;
    char _FillCharacter;
};
