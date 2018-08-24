#include <string>

using namespace std;

class Measurements
{
  private:
    int height;
    int weight;

  public:
    Measurements (const int h, const int w);
    // void Grow();
    // void Shrink();
    // int GetHeight();
    // int GetWeight();
    // void SetHeight(const int h);
    // void SetWeight(const int w);
    void PrintSummary();

};
