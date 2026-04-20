namespace Observer{
     internal interface INewsAgency
    {
        void Attach(ISubscriber subscriber);
        void Detach(ISubscriber subscriber);
        void Notify();
    }
}
