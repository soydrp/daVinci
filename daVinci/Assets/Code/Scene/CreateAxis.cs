using UnityEngine;
using System.Collections;

public class CreateAxis : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float barSeparation = (float)Settings.ENV_MAX_SIZE_WIDTH / (float)JSONtoObj.MainChart.xaxis.values.Count;
        //float barWidth = barSeparation - barGap;

        // XAxis
        for (int numLabel = 0; numLabel < JSONtoObj.MainChart.xaxis.values.Count; numLabel++)  // ... create the X labels
        {
            GameObject newLabel = Instantiate(Resources.Load("prefabs/axis/XAxisLabel"), new Vector3(numLabel * barSeparation, 0, - 0.1f),Quaternion.identity) as GameObject;
            //TextMesh xAxisLabel = new TextMesh();
            //xAxisLabel = newLabel.GetComponent<TextMesh>();
            //Debug.Log(JSONtoObj.MainChart.xaxis.values[numLabel].ToString());
            newLabel.GetComponent<TextMesh>().text = "  " + JSONtoObj.MainChart.xaxis.values[numLabel].ToString();

            float characterSize = (1f / (float)JSONtoObj.MainChart.xaxis.values.Count) * (Settings.ENV_MAX_SIZE_WIDTH / 10f);
            if (characterSize > 0.1f) { characterSize = 0.1f; } // beyond 0.1, font gets too big
            newLabel.GetComponent<TextMesh>().characterSize = characterSize;

            newLabel.transform.Rotate(90f, 0, -90f);
        }


        // YAxis
        float YLineSeparation = (float)Settings.ENV_MAX_SIZE_HEIGHT / 10;
        for (int numYLine = 0; numYLine < 10; numYLine++)
        {
            GameObject YLine = Instantiate(Resources.Load("prefabs/axis/YAxisLine"), new Vector3(((float)Settings.ENV_MAX_SIZE_HEIGHT / 2)+0.7f, YLineSeparation*numYLine, 0),Quaternion.identity) as GameObject;
            GameObject YLineLabel = Instantiate(Resources.Load("prefabs/axis/YAxisLabel"), new Vector3(-0.8f, YLineSeparation*numYLine, 0), Quaternion.identity) as GameObject;

            var YLabelValue= (JSONtoObj.MainChart.yaxis.maxValue / 10) * numYLine;
            YLineLabel.GetComponent<TextMesh>().text= YLabelValue.ToString("0,0"); //TODO: number formatting
    }
}
	// Update is called once per frame
	void Update () {
	
	}
}
