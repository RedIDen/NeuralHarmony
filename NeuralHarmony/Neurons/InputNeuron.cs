namespace NeuralHarmony.Neurons
{
    public class InputNeuron : NeuronBase
    {
        public InputNeuron(string name) : base(name)
        {
        }

        public void Calculate(float input)
        {
            Value = ActivationFinction(input);
        }
    }
}
