using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WebGLSendContractExample : MonoBehaviour
{
    public Text confirmation;

    async public void OnSendContract()
    {
        // smart contract method to call
        string method = "addTotal";
        // abi in json format
        string abi = "[ { \"inputs\": [ { \"internalType\": \"uint8\", \"name\": \"_myArg\", \"type\": \"uint8\" } ], \"name\": \"addTotal\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"myTotal\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" } ]";
        // address of contract
        string contract = "0x2b1a758e19F69bfEB6ab3cd332B999b3EEe02888";
        // array of arguments for contract
        string args = "[\"1\"]";
        // value in wei
        string value = "0";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // connects to user's browser wallet (metamask) to update contract state
        try {
            string response = await Web3GL.SendContract(method, abi, contract, args, value, gasLimit, gasPrice);
            Debug.Log(response);
            confirmation.text = response;
        } catch (Exception e) {
            Debug.LogException(e, this);
        }
    }

    private void Update()
    {
        if(confirmation.text.Contains("0"))
        {
            SceneManager.LoadScene(5);
        }
    }
}
