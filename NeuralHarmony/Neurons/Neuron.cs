namespace NeuralHarmony.Neurons
{
    public class Neuron : NeuronBase
    {
        public List<float> Weights { get; set; }

        public Neuron(string name, List<float> weights) : base(name)
        {
            this.Weights = weights;
        }

        public void Calculate(List<float> inputs)
        {
            if (inputs.Count != this.Weights.Count)
            {
                throw new ArgumentException("A count of inputs must be equal to the count of weights.");
            }

            float sum = 0;

            for (int i = 0; i < this.Weights.Count; i++)
            {
                sum += inputs[i] * this.Weights[i];
            }

            Value = ActivationFinction(sum);
        }

        public void Learn(float error, float learningRate, List<float> inputs)
        {
            if (inputs.Count != this.Weights.Count)
            {
                throw new ArgumentException("A count of inputs must be equal to the count of weights.");
            }

            var delta = error * ActivationFinctionDx(this.Value);

            for (int i = 0; i < this.Weights.Count; i++)
            {
                this.Weights[i] -= inputs[i] * delta * learningRate;
            }
        }
    }
}
