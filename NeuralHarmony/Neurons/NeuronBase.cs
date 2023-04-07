using System.Text.Json.Serialization;

namespace NeuralHarmony.Neurons
{
    [JsonDerivedType(typeof(Neuron), typeDiscriminator: "Neuron")]
    [JsonDerivedType(typeof(InputNeuron), typeDiscriminator: "InputNeuron")]
    public abstract class NeuronBase
    {
        public string Name { get; set; }

        [JsonIgnore]
        public float Value { get; set; }

        public NeuronBase(string name)
        {
            this.Name = name;
        }

        public static float ActivationFinction(float x)
        {
            return (float)(1.0 / (1.0 + Math.Exp(-x)));
        }

        public static float ActivationFinctionDx(float x)
        {
            var activationFunctionResult = ActivationFinction(x);
            return activationFunctionResult / (1.0f - activationFunctionResult);
        }
    }
}
