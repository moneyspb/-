#include "pch.h"
#include "MathLibrary.h"

int cost_trip(int distance, int tarif, int trafficJams)
{
    int base_cost = 50;
    int cost_km = 0;
    if (tarif == 0)
        cost_km = 10;
    else if (tarif == 1)
        cost_km = 15;
    else
        cost_km = 20;

    int cost = base_cost + cost_km * distance;
    if (trafficJams > 3 && trafficJams < 5)
        cost += cost * 0.2;
    else if (trafficJams >= 5)
        cost += cost * 0.5;

    return cost;
}
