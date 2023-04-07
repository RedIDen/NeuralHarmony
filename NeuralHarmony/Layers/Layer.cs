using NeuralHarmony.Neurons;
using System.Text.Json.Serialization;

namespace NeuralHarmony.Layers
{
    public class Layer
    {
        public List<NeuronBase> Neurons { get; set; }

        [JsonIgnore]
        public int Count => Neurons.Count;

        public Layer(List<NeuronBase> neurons)
        {
            this.Neurons = neurons;
        }

        public Layer()
        {
            this.Neurons = new List<NeuronBase>();
        }

        public void Add(NeuronBase neuron)
        {
            this.Neurons.Add(neuron);
        }
    }
}
