namespace Visitor.Good;

public interface Visitor
{
    void VisitRetail(Retail retail);

    void VisitLaw(Law law);

    void VisitRestaurant(Restaurant restaurant);
}
