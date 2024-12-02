namespace ProniaWebApp.ViewModels
{
    public record HomeVm
    {
        public List<SliderVm> sliderVms { get; set; }
        public List<HomeProductVm> homeProductVms { get; set; }

    }
}
