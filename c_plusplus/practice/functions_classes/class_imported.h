#ifndef MEASUREMENTS_H
#define MEASUREMENTS_H

class Measurements
{
  public:
    Measurements (const int h, const int w);
    int GetHeight();
    int GetWeight();
    void SetWeight(const int w);
  private:
    int height;  //in whole inches
    int weight;  //in whole pounds
};

#endif
