package empathicECA.main;

import empathicECA.emotionEngine.EmotionController;

public class ApplicationFacade {
	
	private EmotionController _emotionController;
	
	public ApplicationFacade(){
		
	}
	
	public void startApp(){
		_emotionController = new EmotionController();
		_emotionController.init();
	}
	
}
